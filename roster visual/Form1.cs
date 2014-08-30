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


namespace roster_visual
{
    public partial class Form1 : Form
    {
        Program _Program = new Program();
        Schedule _Schedule = new Schedule();
        Student _Student = new Student();
        RosterMysqlDataContext Context = new RosterMysqlDataContext();
        IQueryable<Student> Filtered_Students;

        // --- Forms ---
        DropForm DropForm = new DropForm();

        public Form1()
        {
            InitializeComponent();

            Filtered_Students = Context.Students;
            studentBindingSource.DataSource = Context.Students;
            

            //--- Load Program/Schedule Defaults ---
            programBindingSource.DataSource = Context.Programs;
            _Program = Context.Programs.First();
            scheduleBindingSource.DataSource = _Program.Schedules.ToList();
            _Schedule = _Program.Schedules.First();


            enrollmentOfficerBindingSource.DataSource = Context.EnrollmentOfficers;

            CurrentSchedulesBindingSource.DataSource = from StudentSchedules in _Student.StudentSchedules
                                                       from Schedules in Context.Schedules
                                                       where StudentSchedules.ScheduleId == Schedules.Id
                                                       select Schedules;

            lockerBindingSource.DataSource = Context.Lockers.Where(l => l.Student.Id == null);

            DropForm.FormClosed += DropForm_FormClosed;

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

        private void button4_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string new_filepath = Application.StartupPath + @"\Student_Pictures\" + Path.GetFileName(openFileDialog.FileName);

                if (!File.Exists(new_filepath)) File.Copy(openFileDialog.FileName, new_filepath);
                else 
                {
                    _Student.Picture = new_filepath;
                    studentImage.Load(new_filepath);
                }
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 4)
            {
                label5.Visible = true;
                textBox1.Visible = true;
            }
            else
            {
                label5.Visible = false;
                textBox1.Visible = false;
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
            Validate();
            Context.SubmitChanges();

            lockerBindingSource.DataSource = Context.Lockers.Where(l => l.Student.Id == null);
        }

        private void studentBindingSource_PositionChanged(object sender, EventArgs e)
        {
            _Student = (Student)studentBindingSource.Current;
            if (_Student.Picture != null) studentImage.Load(_Student.Picture);
                 else studentImage.Image = global::roster_visual.Properties.Resources.noimage;


            dropInfoBindingSource.DataSource = _Student.DropInfo;

            //-- Cambia los label de informacion en el tab Droped teniendo en cuenta si es Balance o Refund
            DropedTabBindManage();

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

            StudentMainTab.SelectedTab = findStudent_tab;
            searchStudent_txt.Focus();
        }

        private void searchStudent_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btn_search_Click(sender, e);
            
        }

        private void button5_Click(object sender, EventArgs e)
        {

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
            dropToolStripMenuItem.Visible = (_Student.DropInfo != null) ? false : true;
        }

        private void DropedTabBindManage()
        {
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



      
    }
}
