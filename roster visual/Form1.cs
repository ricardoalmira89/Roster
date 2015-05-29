using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using roster_visual.Reports;


namespace roster_visual
{
    public partial class MainForm : Form
    {
        Program _Program = new Program();
        Schedule _Schedule = new Schedule();
        Student _Student = new Student();
        RosterMysqlDataContext Context;
        IQueryable<Student> Filtered_Students;
        Security Security;

        // --- Forms ---
        DropForm DropForm = new DropForm();
        StudentCardForm StudentCardForm = new StudentCardForm();
        AttendanceSheetForm AttendanceSheetForm = new AttendanceSheetForm();
        ClassListForm ClassListForm = new ClassListForm();

        public void ShowDialog(RosterMysqlDataContext context, User user)
        {
            InitializeComponent();

            Context = context;
            Security = new Security(StudentMainTab, StudentNavigator);
            Security.DrawTabs(user);

            Filtered_Students = Context.Students;
            studentBindingSource.DataSource = Context.Students;

            //--- Load Program/Schedule Defaults ---
            programBindingSource.DataSource = Context.Programs;
            _Program = Context.Programs.First();
            scheduleBindingSource.DataSource = _Program.Schedules.ToList();
            _Schedule = _Program.Schedules.First();


            //enrollmentOfficerBindingSource.DataSource = Context.EnrollmentOfficers;
            graduatedBindingSource.DataSource = _Student.Graduated;


            lockerBindingSource.DataSource = Context.Lockers.Where(l => l.Student.Id == null);

            RepProgram_cmb.DataSource = Context.Programs;
            DropForm.FormClosed += DropForm_FormClosed;



            ShowDialog();
        }

        public MainForm()
        {
            
            

        }

        void DropForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //-- Para que se actualice el binding ---
            studentBindingSource_PositionChanged(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentMainTab.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            StudentMainTab.Visible = true;
            groupBox1.Visible = true;
        }

        private void loadImage_btn_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                studentImage.Load(openFileDialog.FileName);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 4)
            {
                label5.Visible = true;
                PaymentPlanInfo_txt.Visible = true;
            }
            else
            {
                label5.Visible = false;
                PaymentPlanInfo_txt.Visible = false;
            }

           

        }

        private void program_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                _Program = Context.Programs.First(c => c.Id == (int)program_cmb.SelectedValue);
                _Schedule = _Program.Schedules.First();
                scheduleBindingSource.DataSource = _Program.Schedules.ToList();
            }
            catch (Exception)
            {

            }

        }

        private void schedule_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                _Schedule = Context.Schedules.First(c => c.Id == (int)schedule_cmb.SelectedValue);
            }
            catch (Exception)
            {
            }
            
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            _Student.StartDate = start_DateDateTimePicker.Value;             //-- por si no se selecciono ninguno, el sistema me pone 0000:00:00 por defecto, aunque me muestra la fecha actual en StartDateTimePicker. Asi que se lo asigno si o si.
           // if (_Student.Cv != string.Empty || _Student.Cv != null) _Student.Cv = GeneraCv(_Student);       //-- le asigna un cv en caso de que no tenga solamente.
            _Student.Picture = ImageManager.imageToByteArray(studentImage.Image);

            studentBindingSource.EndEdit();
            Validate();
            Context.SubmitChanges();
            lockerBindingSource.DataSource = Context.Lockers.Where(l => l.Student.Id == null);
            MessageBox.Show("Your Record has been saved");
        }

        private void add_schedule_btn_Click(object sender, EventArgs e)
        {
            if (!_Student.StudentSchedules.ToList().Exists(c => c.ProgramId == _Program.Id))
            {

                _Student.StudentSchedules.Add(new StudentSchedule() { Student = _Student, Schedule = _Schedule, Program = _Program });

                CurrentSchedulesBindingSource.DataSource = from StudentSchedules in _Student.StudentSchedules
                                                           from Schedules in Context.Schedules
                                                           where StudentSchedules.ScheduleId == Schedules.Id
                                                           select Schedules;

            }

            else MessageBox.Show("Current Program already exists for this student.\nPlease select another one.", "Program already exists", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DeleteStudentSchedule_Click(object sender, EventArgs e)
        {

            StudentSchedule StudentSchedule_To_Delete = _Student.StudentSchedules.First(sch => sch.Schedule.Id == (int)studentSchedulesGridView.CurrentRow.Cells["Id"].Value);
            Context.StudentSchedules.DeleteOnSubmit(StudentSchedule_To_Delete);
            _Student.StudentSchedules.Remove(StudentSchedule_To_Delete);


            CurrentSchedulesBindingSource.DataSource = from StudentSchedules in _Student.StudentSchedules
                                                        from Schedules in Context.Schedules
                                                        where StudentSchedules.ScheduleId == Schedules.Id
                                                        select Schedules;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            Filtered_Students = from Students in Context.Students
                                where (
                                (Students.FirstName.ToLower().StartsWith(searchStudent_txt.Text.ToLower()) ||
                                Students.LastName.ToLower().StartsWith(searchStudent_txt.Text.ToLower()) ||
                                Students.Cv.StartsWith(searchStudent_txt.Text))
                                )
                                select Students;

            if (DropFilter_chk.Checked) Filtered_Students = Filtered_Students.Where(s => s.DropInfo != null);

            studentBindingSource.DataSource = Filtered_Students;

            StudentMainTab.SelectedTab = FindTab;
            searchStudent_txt.Focus();
        }

        private void searchStudent_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btn_search_Click(sender, e);
            
        }

        private void locker_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            _Student.Locker = (Locker)locker_cmb.SelectedItem;
            lockerBindingSource.DataSource = Context.Lockers.Where(l => l.Student.Id == null);
        }

        private void dropToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DropForm.ShowDialog(Context,_Student);
        }

        private void DropFilter_chk_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
                Filtered_Students = Filtered_Students.Where(s => s.DropInfo != null);
            else 
                Filtered_Students = from Students in Context.Students
                                     where (
                                     (Students.FirstName.ToLower().StartsWith(searchStudent_txt.Text.ToLower()) ||
                                     Students.LastName.ToLower().StartsWith(searchStudent_txt.Text.ToLower()) ||
                                     Students.Cv.StartsWith(searchStudent_txt.Text))
                                     )
                                     select Students;

            studentBindingSource.DataSource = Filtered_Students;
        }

        private void StudentActionsMenu_Opening(object sender, CancelEventArgs e)
        {
            dropToolStripMenuItem.Enabled = (_Student.DropInfo != null) ? false : true;
            graduateToolStripMenuItem.Enabled = (_Student.Graduated != null) ? false : true;
        }

        private void graduateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to graduate the student " + _Student.FirstName + " " + _Student.LastName+"?", "Graduate Student", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                _Student.Graduated = new Graduated();
                _Student.Status = "Graduated";
                Context.SubmitChanges();
                studentBindingSource_PositionChanged(sender, e);
            }
        }

        private void studentBindingSource_PositionChanged(object sender, EventArgs e)
        {
            _Student = (Student)studentBindingSource.Current;

            if (studentBindingSource.Count > 0) { 

                if (StudentMainTab.SelectedTab == DropTab)    DropTab_Enter(sender, e);
                if (StudentMainTab.SelectedTab == GraduatedTab) GraduatedTab_Enter(sender, e);
                if (StudentMainTab.SelectedTab == EnrollmentTab) EnrollmentTab_Enter(sender, e);

                if (_Student.Graduated == null) Security.Hide("GraduatedTab");
                else
                    Security.Show("GraduatedTab");


                if (_Student.DropInfo == null) StudentMainTab.TabPages.Remove(DropTab);
                else if (!StudentMainTab.TabPages.Contains(DropTab)) StudentMainTab.TabPages.Add(DropTab);

                //--- load the image ---
                if (_Student.Picture != null) studentImage.Image = ImageManager.byteArrayToImage(_Student.Picture);
                else studentImage.Image = global::roster_visual.Properties.Resources.noimage;
            }
        }

        private void DropTab_Enter(object sender, EventArgs e)
        {
            dropInfoBindingSource.DataSource = _Student.DropInfo;

            if (_Student.DropInfo.Refund == true)
            {
                RefundedOrBalance_lbl.Text = "Refund Due";
                RefundedOrPaidDateText_lbl.Text = "To be refunded by:";
            }
            else
            {
                RefundedOrBalance_lbl.Text = "Balance Due";
                RefundedOrPaidDateText_lbl.Text = "To be paid by:";
            }
        }

        private void GraduatedTab_Enter(object sender, EventArgs e)
        {
            graduatedBindingSource.DataSource = _Student.Graduated;
        }

        private void EnrollmentTab_Enter(object sender, EventArgs e)
        {
            CurrentSchedulesBindingSource.DataSource = from StudentSchedules in _Student.StudentSchedules
                                                       from Schedules in Context.Schedules
                                                       where StudentSchedules.ScheduleId == Schedules.Id
                                                       select Schedules;
        }

        private void PrintID_btn_Click(object sender, EventArgs e)
        {
            if (_Student.StudentSchedules.Count != 0)
                StudentCardForm.ShowDialog(Context, _Student.Id);
            else MessageBox.Show("You need to provide Program/Schedule information for this student. Otherwise, ID can't be printed.", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void RepProgram_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            RepSchedules_cmb.DataSource = (RepProgram_cmb.SelectedItem as Program).Schedules;
        }

        private void ShowReport_btn_Click(object sender, EventArgs e)
        {
            Program _program = (Program)RepProgram_cmb.SelectedItem;
            Schedule _schedule = (Schedule)RepSchedules_cmb.SelectedItem;

            IQueryable _studentview = from studentview in Context.Studentviews
                                      where
                                      (studentview.Programid == _program.Id) &&
                                      (studentview.Scheduleid == _schedule.Id) &&
                                      (studentview.StartDate.Date == RepStartDate.Value.Date)
                                      select studentview;

            if (RepSelectReports_cmb.Text == "Attendance Sheet")  AttendanceSheetForm.ShowDialog(_studentview);
            if (RepSelectReports_cmb.Text == "Class List")  ClassListForm.ShowDialog(_studentview);
            if (RepSelectReports_cmb.Text == "Student ID") StudentCardForm.ShowDialog(Context, _Student.Id);

        }

        private string GeneraCv(Student student)
        {
           /*int i = 0;
            var year_students = Context.Students.Where(e => e.StartDate.Year == student.StartDate.Year);
            foreach (Student item in year_students)
            {
                if (item == student) break;
                i++;
            }

            string b;

            if (i < 9) b = "00" + i.ToString();
                else 
                    if (i < 99) b = "0" + i.ToString();
                        else b = i.ToString();

            string year = student.StartDate.Year.ToString();
            year = year[0].ToString() + year[2].ToString() + year[3].ToString();

            return year + b;*/
            return "";
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void studentBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchStudent_GridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DropTab_Click(object sender, EventArgs e)
        {

        }

        private void add_btn_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
