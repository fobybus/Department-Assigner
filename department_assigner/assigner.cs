using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace department_assigner
{
    public partial class assigner : Form
    {
        //variables
        private ArrayList departments=new ArrayList();
        private ArrayList dep_capa= new ArrayList();
        private int dept_count = 0;

        //students obj list 
        private List<student> students_obj=new List<student>();
        private int[] temp_choice;
        private int selectedcount = 0;
        private int student_count = 0;
        //

        //end variables 

        public assigner()
        {
            InitializeComponent();
        }


        //add clicked 
        private void add_Click(object sender, EventArgs e)
        {

            //check if the capacity is not num and null text field
            int capnum;
            if ((!Int32.TryParse(cap.Text,out capnum)) || dname.Text=="")
                {

                MessageBox.Show(this,"error occured \n can't proceed","invalid input",MessageBoxButtons.OK,MessageBoxIcon.Error);
                //reset the texts 
                dname.Text = "";
                cap.Text = "";
                } else {
                //add the input to the lists;
                departments.Add(dname.Text);
                dep_capa.Add(capnum);

                //display to the listview
                listView1.Items.Add(dname.Text);
                listView1.Items.Add(" "+capnum.ToString());

                //check if department value is exceeded to 2 
                //enable the next button if 
                if (departments.Count >= 2)
                    next.Enabled = true;
                else
                    next.Enabled = false;
                //clear
                dname.Text = "";
                cap.Text = "";

            }



        }  // end add clicked 

        //next clicked
        private void next_Click(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            groupBox1.Enabled = true;
            //set total dep count 
            dept_count = departments.Count;
            //////
            //add department list and nth list 
            for(int i=0,j=1;i<dept_count;i++,j++)
            {
                nth_l.Items.Add(j);
            }

            //add the departments 
            for (int i = 0; i < dept_count; i++)
            {
                choice_l.Items.Add(departments[i]);
            }
            //set selected index by default 
            nth_l.SelectedIndex = 0;
            choice_l.SelectedIndex = 0;
            temp_choice = new int[dept_count];

        }



        //select clicked 
        private void selec_b_Click(object sender, EventArgs e)
        {
            if(choice_l.Text=="selected" || nth_l.Text=="selected")
            {
                MessageBox.Show(this, "already selected ", "invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else {
            int nindex = nth_l.SelectedIndex;
            temp_choice[nindex] = choice_l.SelectedIndex;
                //mark selected 
                choice_l.Items[choice_l.SelectedIndex] = "selected";
                nth_l.Items[nth_l.SelectedIndex] = "selected";
                choice_l.Text = "selected";
                nth_l.Text = "selected";
                selectedcount++;
                if (selectedcount == dept_count)
                {
                    MessageBox.Show("all department selected!");
                    add_s.Enabled = true;
                    selec_b.Enabled = false;
                    
                }
                    

            }


        }  //end selected clck 


        // add student clicked 
        private void add_s_Click(object sender, EventArgs e)
        {
            double average;
            if(textBox_name.Text=="" || (!Double.TryParse(textBox_ave.Text,out average)) || selectedcount!=dept_count)
            {
                MessageBox.Show(this, "error occured \n can't proceed,please fill all", "invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                //ENABLE ASSIGN DEPARTMENT WHEN FIRST STUDENT ADDED ;
                assign_b.Enabled = true;
                //create new object 
                student studentobj = new student();
                studentobj.fullname = textBox_name.Text;
                studentobj.ave = average;
                studentobj.choice = new int[dept_count];
                temp_choice.CopyTo(studentobj.choice, 0);
                //APPEND TO THE LIST 
                students_obj.Add(studentobj);
                //clear the vars and inputs set to default 
                textBox_ave.Text = "";
                textBox_name.Text = "";
                //restore  department list and nth list 
                for (int i = 0, j = 1; i < dept_count; i++, j++)
                {
                    nth_l.Items[i]=(j);
                }

                //restore  the departments 
                for (int i = 0; i < dept_count; i++)
                {
                    choice_l.Items[i]=departments[i];
                }

                //set selected index by default 
                nth_l.SelectedIndex = 0;
                choice_l.SelectedIndex = 0;

                //disable add student button and enable select 
                add_s.Enabled = false;
                selec_b.Enabled = true;
                //reset selected count
                selectedcount = 0;
                //increment student count and show 
                student_count++;
                screen_sadd.Text = student_count.ToString();
                
            }
        } //end add students 


        //assign clicked 
        private void assign_b_Click(object sender, EventArgs e)
        {
            emmitor emit = new emmitor(students_obj, departments, dep_capa, dept_count);
            emit.distribute();
        } //end assign clicked 

////////////////////////////////////
///function that print the array content of int 
///
  public void print_A(int [] array)
        {
            string string_array="";
            for(int i=0;i<array.Length;i++)
            {
                string_array += array[i];
            }

            MessageBox.Show(string_array);
        }
       
    } // end assigner class

} //end namespace std 
