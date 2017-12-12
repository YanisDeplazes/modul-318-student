using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Threading;



namespace WindowsFormsApp2
{

    public partial class Form1 : Form
    {
        bool focusontext = true;
        Transport transport;
        
        public Form1()



        {
            InitializeComponent();

            transport = new Transport();

        }



        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (focusontext == true)
            {


                if (!String.IsNullOrEmpty(StartstationInput.Text))
                {
                    Auswahl1.Visible = true;
                    Auswahl1.Items.Clear();

                    List<Station> stations = transport.GetStations(StartstationInput.Text).StationList;
                    foreach (Station station in stations)
                    {
                        Auswahl1.Items.Add(station.Name);
                    }
                }

                else
                {
                    Auswahl1.Visible = false;
                    GoogleMapsSearch1.Visible = false;
                }
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            if (focusontext == true)
            {
                if (!String.IsNullOrEmpty(EndstationInput.Text))
                {
                    Auswahl2.Visible = true;
                    Auswahl2.Items.Clear();

                    List<Station> stations = transport.GetStations(EndstationInput.Text).StationList;
                    foreach (Station station in stations)
                    {
                        Auswahl2.Items.Add(station.Name);
                    }




                }
                else
                {
                    Auswahl2.Visible = false;
                    GoogleMapsSearch2.Visible = false;
                }
            }
        }
        private void Auswahl1_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        private void DoubleClick1(object sender, EventArgs e)
        {
            StartstationInput.Text = Auswahl1.SelectedItem.ToString();
            Auswahl1.Items.Clear();
            Auswahl1.Visible = false;
            GoogleMapsSearch1.Visible = true;
            dataGridView1.Rows.Clear();
            SwissTransport.Transport connection = new SwissTransport.Transport();
            var connect = connection.GetConnections(StartstationInput.Text, EndstationInput.Text);
            foreach (var conn in connect.ConnectionList)
            {

                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = StartstationInput.Text;
                row.Cells[1].Value = DateTime.Parse(conn.From.Departure).ToString("HH:mm");
                row.Cells[2].Value = conn.From.Platform;
                row.Cells[3].Value = EndstationInput.Text;
                row.Cells[4].Value = DateTime.Parse(conn.To.Arrival).ToString("HH:mm");
                row.Cells[5].Value = conn.To.Platform;
                row.Cells[6].Value = conn.To.Delay;
                dataGridView1.Rows.Add(row);
                Ankunftsstation.Visible = true;
                Ankunftszeit.Visible = true;
                Ankunftszone.Visible = true;
                Verspätung.Visible = true;
            }
        }



        private void DoubleClick2(object sender, EventArgs e)
        {
            EndstationInput.Text = Auswahl2.SelectedItem.ToString();
            Auswahl2.Items.Clear();
            Auswahl2.Visible = false;
            GoogleMapsSearch2.Visible = true;


            dataGridView1.Rows.Clear();
            SwissTransport.Transport connection = new SwissTransport.Transport();
            var connect = connection.GetConnections(StartstationInput.Text, EndstationInput.Text);
            foreach (var conn in connect.ConnectionList)
            {

                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = StartstationInput.Text;
                row.Cells[1].Value = DateTime.Parse(conn.From.Departure).ToString("HH:mm");
                row.Cells[2].Value = conn.From.Platform;
                row.Cells[3].Value = EndstationInput.Text;
                row.Cells[4].Value = DateTime.Parse(conn.To.Arrival).ToString("HH:mm");
                row.Cells[5].Value = conn.To.Platform;
                row.Cells[6].Value = conn.To.Delay;
                dataGridView1.Rows.Add(row);
                Ankunftsstation.Visible = true;
                Ankunftszeit.Visible = true;
                Ankunftszone.Visible = true;
                Verspätung.Visible = true;
            }
        }

        public void button3_Click(object sender, EventArgs e)
        {

            if (Auswahl1.Visible == true)
            {
                StartstationInput.Text = "";
            }
            if (Auswahl2.Visible == true)
            {
                EndstationInput.Text = "";
            }
            focusontext = false;
            string change = "";
            change = EndstationInput.Text;
            EndstationInput.Text = StartstationInput.Text;
            StartstationInput.Text = change;
            focusontext = true;
            GoogleMapsSearch1.Visible = true;
            GoogleMapsSearch2.Visible = true;
            if (String.IsNullOrEmpty(EndstationInput.Text))
            {
                GoogleMapsSearch2.Visible = false;
               
            }
            if (String.IsNullOrEmpty(StartstationInput.Text))
            {       
                GoogleMapsSearch1.Visible = false;
               
            }

            dataGridView1.Rows.Clear();
            SwissTransport.Transport connection = new SwissTransport.Transport();
            var connect = connection.GetConnections(StartstationInput.Text, EndstationInput.Text);
            foreach (var conn in connect.ConnectionList)
            {

                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = StartstationInput.Text;
                row.Cells[1].Value = DateTime.Parse(conn.From.Departure).ToString("HH:mm");
                row.Cells[2].Value = conn.From.Platform;
                row.Cells[3].Value = EndstationInput.Text;
                row.Cells[4].Value = DateTime.Parse(conn.To.Arrival).ToString("HH:mm");
                row.Cells[5].Value = conn.To.Platform;
                row.Cells[6].Value = conn.To.Delay;
                dataGridView1.Rows.Add(row);
                Ankunftsstation.Visible = true;
                Ankunftszeit.Visible = true;
                Ankunftszone.Visible = true;
                Verspätung.Visible = true;
            }

        }

        public void button4_Click(object sender, EventArgs e)
        {
            if (!(StartstationInput.Text == "") && (Auswahl1.Visible == false))
            {
                dataGridView1.Rows.Clear();
                SwissTransport.Transport stationboard = new SwissTransport.Transport();
                var station = stationboard.GetStationBoard(StartstationInput.Text);
                foreach (var stat in station.Entries)
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                    row.Cells[0].Value = StartstationInput.Text;
                    row.Cells[1].Value = stat.Stop.Departure.ToShortTimeString();
                    row.Cells[2].Value = stat.Stop.Platform;
                    Ankunftsstation.Visible = false;
                    Ankunftszeit.Visible = false;
                    Ankunftszone.Visible = false;
                    Verspätung.Visible = false;
                    dataGridView1.Rows.Add(row);
                }
            }
            else
            {
                MessageBox.Show("Kein Ort eingegeben!", "Error");
                dataGridView1.Rows.Clear();
            }
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!(StartstationInput.Text == ""))
            {
                var station = StartstationInput.Text;
                string adresse = "https://www.google.ch/maps/place/" + station.ToString();
                System.Diagnostics.Process.Start(adresse);
            }
            else
            {
                MessageBox.Show("Kein Ort eingegeben!", "OK");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!(EndstationInput.Text == ""))
            {
                var station = EndstationInput.Text;
                string adresse = "https://www.google.ch/maps/place/" + station.ToString();
                System.Diagnostics.Process.Start(adresse);
            }
            else
            {
                MessageBox.Show("Kein Ort eingegeben!", "OK");
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string mailBody = "<table width='100%' style='border:Solid 1px Black;'>";

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                mailBody += "<tr>";
                foreach (DataGridViewCell cell in row.Cells)
                {
                    mailBody += "<td stlye='color:blue;'>" + cell.Value + "</td>";
                }
                mailBody += "</tr>";
            }
            mailBody += "</table>";

          
            
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("yanisdeplazes@gmail.com");
                mail.To.Add("to_address");
                mail.Subject = "Test Mail";
                mail.Body = mailBody;

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("yanisdeplazes", "Yanis");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                MessageBox.Show("mail Send");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

    }
}
