using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace department_assigner
{
    internal class emmitor
    {
        //emmit students for the departments ^_^
        private List<student> studentlist;
        private ArrayList deps;
        private ArrayList dep_capacity;
        private int dept_count;
        //other variables 

        public emmitor(List<student> studentlist,ArrayList deps,ArrayList dep_capacity,int depcount)
        {
            this.studentlist = studentlist;
            this.deps = deps;
            this.dep_capacity = dep_capacity;
            this.dept_count = depcount;
           

        }  

        public void distribute()
        {
            //////////////////////////////
            ///sort the student objs based on there mark !
            /// we will implement our comparer that compare our object based on students  grades .
            ///  compairer class name=compairer !!
            compairer comp = new compairer();
            studentlist.Sort(comp);
            //prepare variables 
            List <List<student>> adjusted= new List<List<student>>();
            for(int i=0;i<dept_count;i++)
            {
               adjusted.Add(new List<student>());
            }
            //now the department with highest priority or highest number select the student  first if they put the dep first 
            //after that others will  contniue to select the student's
            
            
            for(int i=0;i<dept_count;i++)
            {
                //at the start every department select student's with first choice 
                //then if department not full they continue until they became a full 2,3, up to dep length 
                 for(int j=0;j<dept_count;j++)
                {
                    int intake;
                    intake = (int)dep_capacity[j];
                    int f = 0;
                   while(adjusted[j].Count<=intake && f<studentlist.Count)
                    {
                        //while not full and there is student search until the end and match 
                        if(studentlist[f].choice[j]==i)
                        {
                            //take the student;
                            adjusted[j].Add(studentlist[f]);
                            //remove from the studentlist
                            studentlist.RemoveAt(f);
                        }
                        f++;

                    } //end while loop
                 
                }  //end inner for loop

            } //end forloop

            //create database 
            connection con = new connection();
            SqlConnection conn = con.GetConnection();
            conn.Open();
            SqlCommand command = new SqlCommand("create table result(fulln varchar(50),dep varchar(50))", conn);
            try
            {
                int qresult=command.ExecuteNonQuery();
                if (qresult!=null)
                {

                    MessageBox.Show("created the table result.............");
                }
                else
                {

                    MessageBox.Show("can creat the table");
                }
                //////////////////insert the data to the table 
                ///


                for (int i = 0; i < adjusted.Count; i++)
                {

                    for (int j = 0; j < adjusted[i].Count; j++)
                    {
                        command = new SqlCommand("insert into result(fulln,dep) values(@fn,@dep)", conn);
                        command.Parameters.AddWithValue("@fn", adjusted[i][j].fullname);
                        command.Parameters.AddWithValue("@dep", (string)(deps[i]));
                        int r = command.ExecuteNonQuery();
                    }

                }

                MessageBox.Show("successfully assigned department & it is now saved to database");
                DataTable dt=new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter("select * from result", conn);
                adapter.Fill(dt);
                view v=new view(dt,adapter);
                  
            }catch (Exception exp)
            {
                MessageBox.Show("can't write to the database! \n error occured"+exp.Message);
               
            }
            finally
            {
                conn.Close();
            }

            

        } //end distrube 


        //this function for debugging only  
        //print a student list one by one 
        public void printlist(List<student> list)
        {
            int len = list.Count;
            string result="";
            for(int i=0;i<len;i++)
            {
                result += list[i].fullname+" "+list[i].ave+" "+list[i].choice.ToString()+"\n";
            }

            MessageBox.Show(result);
        }

    } //end emmiter class
} //end namespace 
