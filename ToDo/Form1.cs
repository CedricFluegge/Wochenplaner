using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDo
{

    

    public partial class Form1 : Form
    {
        public int dayint;
        public int day;
        public int howmanytaskmo = 0;
        public int howmanytaskdi = 0;
        public int howmanytaskmi = 0;
        public int howmanytaskdo = 0;
        public int howmanytaskfr = 0;
        public int howmanytasksa = 0;
        public int howmanytaskso = 0;

        //ToDo
        //Alle tage hinzufügen 
        //Prioritat hinzufügen indem man position(tag) ändert
        //Done hinzufügen

        public Form1()
        {
            InitializeComponent();
        }
      
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void Assigntaskbtn_Click(object sender, EventArgs e)
        {
            Add();
        }

        public void Add()
        {
            Tasks Task = new Tasks();

            switch (day)
            {
                case 1:
                    Task.AddTask(howmanytaskmo, rtbx1.Text, done1mo, done2mo, done3mo, done4mo, done5mo,
                                 taskbtn1mo, taskbtn2mo, taskbtn3mo, taskbtn4mo, taskbtn5mo);

                    howmanytaskmo = Task.dayposiotion;
                    break;

                case 2:
                    Task.AddTask(howmanytaskdi, rtbx1.Text, done1di, done2di, done3di, done4di, done5di,
                                 taskbtn1di, taskbtn2di, taskbtn3di, taskbtn4di, taskbtn5di);

                    howmanytaskdi = Task.dayposiotion;
                    break;

                case 3:
                    Task.AddTask(howmanytaskmi, rtbx1.Text, done1mi, done2mi, done3mi, done4mi, done5mi,
                                 taskbtn1mi, taskbtn2mi, taskbtn3mi, taskbtn4mi, taskbtn5mi);

                    howmanytaskmi = Task.dayposiotion;
                    break;

                case 4:
                    Task.AddTask(howmanytaskdo, rtbx1.Text, done1do, done2do, done3do, done4do, done5do,
                                 taskbtn1do, taskbtn2do, taskbtn3do, taskbtn4do, taskbtn5do);

                    howmanytaskdo = Task.dayposiotion;
                    break;

                case 5:
                    Task.AddTask(howmanytaskfr, rtbx1.Text, done1fr, done2fr, done3fr, done4fr, done5fr,
                                 taskbtn1fr, taskbtn2fr, taskbtn3fr, taskbtn4fr, taskbtn5fr);

                    howmanytaskfr = Task.dayposiotion;
                    break;

                case 6:
                    Task.AddTask(howmanytasksa,rtbx1.Text, done1sa, done2sa, done3sa, done4sa, done5sa,
                                 taskbtn1sa, taskbtn2sa, taskbtn3sa, taskbtn4sa, taskbtn5sa);

                    howmanytasksa = Task.dayposiotion;
                    break;

                case 7:
                    Task.AddTask(howmanytaskso, rtbx1.Text, done1so, done2so, done3so, done4so, done5so,
                                 taskbtn1so, taskbtn2so, taskbtn3so, taskbtn4so, taskbtn5so);

                    howmanytaskso = Task.dayposiotion;
                    break;
            }
            
        }
        private void btnmontag_Click(object sender, EventArgs e)
        {
            ButtonControlDays(btnmontag);
            if (btnmontag.BackColor == Color.DarkRed)
            {
                day = 1;
            }
        }
        private void btndienstag_Click(object sender, EventArgs e)
        {
            ButtonControlDays(btndienstag);
            if (btndienstag.BackColor == Color.DarkRed)
            {
                day = 2;
            }
        }
        private void btnmittwoch_Click(object sender, EventArgs e)
        {
            ButtonControlDays(btnmittwoch);
            if (btnmittwoch.BackColor == Color.DarkRed)
            {
                day = 3;
            }
        }
        private void btndonnerstag_Click(object sender, EventArgs e)
        {
            ButtonControlDays(btndonnerstag);
            if (btndonnerstag.BackColor == Color.DarkRed)
            {
                day = 4;
            }
        }
        private void btnfreitag_Click(object sender, EventArgs e)
        {
            ButtonControlDays(btnfreitag);
            if (btnfreitag.BackColor == Color.DarkRed)
            {
                day = 5;
            }
        }
        private void btnsamstag_Click(object sender, EventArgs e)
        {
            ButtonControlDays(btnsamstag);
            if (btnsamstag.BackColor == Color.DarkRed)
            {
                day = 6;
            }
        }
        private void btnsonntag_Click(object sender, EventArgs e)
        {
            ButtonControlDays(btnsonntag);
            if (btnsonntag.BackColor == Color.DarkRed)
            {
                day = 7;
            }
        }


        //Sorgt dafür das nur einer der tage ausgewählt wird
        public void ButtonControlDays(Button day)
        {

            if (day.BackColor == Color.Gray && dayint == 0)
            {
                day.BackColor = Color.DarkRed;
                dayint = 1;
            }
            else if (day.BackColor == Color.DarkRed)   
            {
                day.BackColor = Color.Gray;
                dayint = 0;
            }
        }

        public void Delete(int day, int number)
        {
            Tasks task = new Tasks();

            switch (day)
            {
                //Montag
                case 1:    
                        task.dayposiotion = howmanytaskmo;
                        task.DeleteTask(number, howmanytaskmo, done1mo, done2mo, done3mo, done4mo, done5mo,
                             taskbtn1mo, taskbtn2mo, taskbtn3mo, taskbtn4mo, taskbtn5mo);
                        howmanytaskmo -= 1;
                    break;
                //Dienstag
                case 2:
                    task.dayposiotion = howmanytaskdi;
                    task.DeleteTask(number, howmanytaskdi, done1di, done2di, done3di, done4di, done5di,
                         taskbtn1di, taskbtn2di, taskbtn3di, taskbtn4di, taskbtn5di);
                    howmanytaskdi -= 1;
                    break;
                //Mittwoch
                case 3:
                    task.dayposiotion = howmanytaskmi;
                    task.DeleteTask(number, howmanytaskmi, done1mi, done2mi, done3mi, done4mi, done5mi,
                         taskbtn1mi, taskbtn2mi, taskbtn3mi, taskbtn4mi, taskbtn5mi);
                    howmanytaskmi -= 1;
                    break;
                //Donnerstag
                case 4:
                    task.dayposiotion = howmanytaskdo;
                    task.DeleteTask(number, howmanytaskdo, done1do, done2do, done3do, done4do, done5do,
                         taskbtn1do, taskbtn2do, taskbtn3do, taskbtn4do, taskbtn5do);
                    howmanytaskdo -= 1;
                    break;
                //Freitag
                case 5:
                    task.dayposiotion = howmanytaskfr;
                    task.DeleteTask(number, howmanytaskfr, done1fr, done2fr, done3fr, done4fr, done5fr,
                         taskbtn1fr, taskbtn2fr, taskbtn3fr, taskbtn4fr, taskbtn5fr);
                    howmanytaskfr -= 1;
                    break;
                //Samstag
                case 6:
                    task.dayposiotion = howmanytasksa;
                    task.DeleteTask(number, howmanytasksa, done1sa, done2sa, done3sa, done4sa, done5sa,
                         taskbtn1sa, taskbtn2sa, taskbtn3sa, taskbtn4sa, taskbtn5sa);
                    howmanytasksa -= 1;
                    break;
                //Sontag
                case 7:
                    task.dayposiotion = howmanytaskso;
                    task.DeleteTask(number, howmanytaskso, done1so, done2so, done3so, done4so, done5so,
                         taskbtn1so, taskbtn2so, taskbtn3so, taskbtn4so, taskbtn5so);
                    howmanytaskso -= 1;
                    break;
                default:
                    MessageBox.Show("Error");
                    break;

            }
        }
        private void done1mo_Click(object sender, EventArgs e)
        {
            // Tag Montag   Button 1
            Delete(1, 1);

        }

        private void done2mo_Click(object sender, EventArgs e)
        {
            Delete(1, 2);
        }

        private void done3mo_Click(object sender, EventArgs e)
        {
            Delete(1, 3);
        }

        private void done4mo_Click(object sender, EventArgs e)
        {
            Delete(1, 4);
        }

        private void done5mo_Click(object sender, EventArgs e)
        {
            Delete(1, 5);
        }

        private void done1di_Click(object sender, EventArgs e)
        {
            Delete(2, 1);
        }

        private void done2di_Click(object sender, EventArgs e)
        {
            Delete(2, 2);
        }

        private void done3di_Click(object sender, EventArgs e)
        {
            Delete(2, 3);
        }

        private void done4di_Click(object sender, EventArgs e)
        {
            Delete(2, 4);
        }

        private void done5di_Click(object sender, EventArgs e)
        {
            Delete(2, 5);
        }

        private void done1mi_Click(object sender, EventArgs e)
        {
            Delete(3, 1);
        }

        private void done2mi_Click(object sender, EventArgs e)
        {
            Delete(3, 2);
        }

        private void done3mi_Click(object sender, EventArgs e)
        {
            Delete(3, 3);
        }

        private void done4mi_Click(object sender, EventArgs e)
        {
            Delete(3, 4);
        }

        private void done5mi_Click(object sender, EventArgs e)
        {
            Delete(3, 5);
        }

        private void done1do_Click(object sender, EventArgs e)
        {
            Delete(4, 1);
        }

        private void done2do_Click(object sender, EventArgs e)
        {
            Delete(4, 2);
        }

        private void done3do_Click(object sender, EventArgs e)
        {
            Delete(4, 3);
        }

        private void done4do_Click(object sender, EventArgs e)
        {
            Delete(4, 4);
        }

        private void done5do_Click(object sender, EventArgs e)
        {
            Delete(4, 5);
        }

        private void done1fr_Click(object sender, EventArgs e)
        {
            Delete(5, 1);
        }

        private void done2fr_Click(object sender, EventArgs e)
        {
            Delete(5, 2);
        }

        private void done3fr_Click(object sender, EventArgs e)
        {
            Delete(5, 3);
        }

        private void done4fr_Click(object sender, EventArgs e)
        {
            Delete(5, 4);
        }

        private void done5fr_Click(object sender, EventArgs e)
        {
            Delete(5, 5);
        }

        private void done1sa_Click(object sender, EventArgs e)
        {
            Delete(6, 1);
        }

        private void done2sa_Click(object sender, EventArgs e)
        {
            Delete(6, 2);
        }

        private void done3sa_Click(object sender, EventArgs e)
        {
            Delete(6, 3);
        }

        private void done4sa_Click(object sender, EventArgs e)
        {
            Delete(6, 4);
        }

        private void done5sa_Click(object sender, EventArgs e)
        {
            Delete(6, 5);
        }

        private void done1so_Click(object sender, EventArgs e)
        {
            Delete(7, 1);
        }

        private void done2so_Click(object sender, EventArgs e)
        {
            Delete(7, 2);
        }

        private void done3so_Click(object sender, EventArgs e)
        {
            Delete(7, 3);
        }

        private void done4so_Click(object sender, EventArgs e)
        {
            Delete(7, 4);
        }

        private void done5so_Click(object sender, EventArgs e)
        {
            Delete(7, 5);
        }
    
    }
    class Tasks
    {
        public int dayposiotion;

        public int AddTask(int position, string tasktext, Button done1, Button done2, Button done3, Button done4,
            Button done5, Button task1, Button task2, Button task3, Button task4, Button task5)
        {
            switch (position)
            {
                case 0:
                    done1.Visible = true;
                    task1.Visible = true;
                    task1.Text = tasktext;
                    position = 1;
                    break;
                case 1:
                    done2.Visible = true;
                    task2.Visible = true;
                    task2.Text = tasktext;
                    position = 2;
                    break;
                case 2:
                    done3.Visible = true;
                    task3.Visible = true;
                    task3.Text = tasktext;
                    position = 3;
                    break;
                case 3:
                    done4.Visible = true;
                    task4.Visible = true;
                    task4.Text = tasktext;
                    position = 4;
                    break;
                case 4:
                    done5.Visible = true;
                    task5.Visible = true;
                    task5.Text = tasktext;
                    position = 5;
                    break;
                default:
                    MessageBox.Show("Zu viele Aufgaben berüg dich!");
                    break;
            }
            dayposiotion = position;
            return dayposiotion;

        }
        public int DeleteTask(int whichbutton, int howmanytask, Button done1, Button done2, Button done3, Button done4,
            Button done5, Button task1, Button task2, Button task3, Button task4, Button task5)
        {
            //Was muss beachtet werden
            // 1: Howmanytask je nach tag muss geändert werden und zurück gegeben werden                    #Check
            // 2: Text von anderen Task versetzten                                                          #Check
            // 3: Je nach Delete letzte task nach verschieben des textes == Text = ""; visible = false;     #Check
            // 4: Methode schreiben für tag
            // 5: Welcher button wird gedrückt welche reihe (int whichbutton)                               #Check


            //Wie viele Task gibt es 
            switch (howmanytask)
            {
                //Es exestiert 1 Task
                case 1:
                    done1.Visible = false;
                    task1.Visible = false;
                    task1.Text = "";
                    howmanytask = 0;
                    break;
                //Es existieren 2 Task
                case 2:
                    switch (whichbutton)
                    {
                        //done1 button wurde gedrückt
                        case 1:
                            task1.Text = task2.Text;
                            task2.Text = "";
                            task2.Visible = false;
                            done2.Visible = false;
                            break;
                        //done2 button wurde gedrückt
                        case 2:
                            task2.Text = "";
                            done2.Visible= false;
                            task2.Visible= false;
                            break;
                    }
                    howmanytask = 1;
                    break;
                //Es existieren 3 Task
                case 3:
                    switch (whichbutton)
                    {
                        //done1 button wurde gedrückt
                        case 1:
                            task1.Text = task2.Text;
                            task2.Text = task3.Text;
                            task3.Text = "";
                            task3.Visible = false;
                            done3.Visible = false;
                            break;
                        //done2 button wurde gedrückt
                        case 2:
                            task2.Text = task3.Text;
                            task3.Text = "";
                            task3.Visible = false;
                            done3.Visible = false;
                            break;
                        //done3 button wurde gedrückt
                        case 3:
                            task3.Text = "";
                            task3.Visible = false;
                            done3.Visible = false;
                            break;                      
                    }
                    howmanytask = 2;
                    break;
                //Es existieren 4 Task
                case 4:
                    switch (whichbutton)
                    {
                        //done1 button wurde gedrückt
                        case 1:
                            task1.Text = task2.Text;
                            task2.Text = task3.Text;
                            task3.Text = task4.Text;
                            task4.Text = "";
                            task4.Visible = false;
                            done4.Visible = false;
                            break;
                        //done2 button wurde gedrückt
                        case 2:
                            task2.Text = task3.Text;
                            task3.Text = task4.Text;
                            task4.Text = "";
                            task4.Visible = false;
                            done4.Visible = false;
                            break;
                        //done3 button wurde gedrückt
                        case 3:
                            task3.Text = task4.Text;
                            task4.Text = "";
                            task4.Visible = false;
                            done4.Visible = false;
                            break;
                        //done4 button wurde gedrückt
                        case 4:
                            task4.Text = "";
                            task4.Visible = false;
                            done4.Visible = false;
                            break;                        
                    }
                    howmanytask = 3;
                    break;
                //Es existieren 5 Task
                case 5:
                    switch (whichbutton)
                    {
                        //done1 button wurde gedrückt
                        case 1:
                            task1.Text = task2.Text;
                            task2.Text = task3.Text;
                            task3.Text = task4.Text;
                            task4.Text = task5.Text;
                            task5.Text = "";
                            task5.Visible = false;
                            done5.Visible = false;
                            break;
                        //done2 button wurde gedrückt
                        case 2:
                            task2.Text = task3.Text;
                            task3.Text = task4.Text;
                            task4.Text = task5.Text;
                            task5.Text = "";
                            task5.Visible = false;
                            done5.Visible = false;
                            break;
                        //done3 button wurde gedrückt
                        case 3:
                            task3.Text = task4.Text;
                            task4.Text = task5.Text;
                            task5.Text = "";
                            task5.Visible = false;
                            done5.Visible = false;
                            break;
                        //done4 button wurde gedrückt
                        case 4:
                            task4.Text = task5.Text;
                            task5.Text = "";
                            task5.Visible = false;
                            done5.Visible = false;
                            break;
                        //done5 button wurde gedrückt
                        case 5:
                            task5.Text = "";
                            task5.Visible = false;
                            done5.Visible = false;
                            break;
                    }
                    howmanytask = 4;
                    break;

            }
            dayposiotion = howmanytask;
            return dayposiotion;
        }
    }
}