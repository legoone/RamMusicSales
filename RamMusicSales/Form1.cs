using System.IO;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace RamMusicSales
{
    //Tyler Ramcharan
    public partial class Form1 : Form
    {
        private string genreName;
        const string HIPHOP = "Hip-Hop";
        const string ROCK = "Rock";
        const string POP = "Pop";
        const string COUNTRY = "Country";
        const string JAZZ = "Jazz";
        const string TECHNO = "Techno";
        private string songName;
        private double pricePerPlay;
        private double songPlays;
        private double HiphopDiscountRate;
        private double RockDiscountRate;
        private double PopDiscountRate;
        private double CountryDiscountRate;
        private double JazzDiscountRate;
        private double TechnoDiscountRate;

        private Form2 settingForm;

        public string MusicLog = "MusicLog.txt";
        public string MusicConfig = "MusicConfig.txt";

        public double SongPlays
        {
            get { return songPlays; }
            set { songPlays = value; }
        }
        public double PricePerPlay
        {
            get { return pricePerPlay; }
            set { pricePerPlay = value; }
        }
        public double HipHop
        {
            get { return HiphopDiscountRate; }
            set { HiphopDiscountRate = value; }
        }

        public double Rock
        {
            get { return RockDiscountRate; }
            set { RockDiscountRate = value; }
        }
        public double Pop
        {
            get { return PopDiscountRate; }
            set { PopDiscountRate = value; }
        }
        public double Country
        {
            get { return CountryDiscountRate; }
            set { CountryDiscountRate = value; }
        }
        public double Jazz
        {
            get { return JazzDiscountRate; }
            set { JazzDiscountRate = value; }
        }
        public double Techno
        {
            get { return TechnoDiscountRate; }
            set { TechnoDiscountRate = value; }
        }
        public Form1()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            DialogResult ButtonSelected;
            ButtonSelected = MessageBox.Show(
                "Do you really want ot Quit?", "Exiting",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (ButtonSelected == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSongName.Clear();
            txtPlays.Clear();
            txtSong.Clear();
            lstCalc.Items.Clear();
            rbtnHipHop.Checked = true;
            txtSongName.Focus();
            
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int songPlays;
            double pricePerPlay, streamTTL;
            string songName;
            bool validPricePerPlay, validSongPlays;
            double genreDiscount = 0;
            
            songName = txtSongName.Text;


            validPricePerPlay = double.TryParse(txtSong.Text, out pricePerPlay);
            validSongPlays = int.TryParse(txtPlays.Text, out songPlays);


            if (validPricePerPlay && validSongPlays)
            {
                switch (genreName)
                {
                    case HIPHOP:

                        genreDiscount = HiphopDiscountRate;
                        break;
                    case ROCK:
                        genreDiscount = RockDiscountRate;
                        break;
                    case POP:
                        genreDiscount = PopDiscountRate;
                        break;
                    case COUNTRY:
                        genreDiscount = CountryDiscountRate;
                        break;
                    case JAZZ:
                        genreDiscount = JazzDiscountRate;
                        break;
                    case TECHNO:
                        genreDiscount = TechnoDiscountRate;
                        break;
                    default:
                        lstCalc.Items.Add("This should never happen");
                        break;
                }

                //processing

                StreamWriter sw;

                //output


                streamTTL = songPlays * genreDiscount * pricePerPlay;
                lstCalc.Items.Add(DateTime.Now.ToString("D"));
                lstCalc.Items.Add("The song genre is " + genreName);
                lstCalc.Items.Add("The song name is " + songName);
                lstCalc.Items.Add("There are " + songPlays.ToString("N0") + " song plays");
                lstCalc.Items.Add("Song cost is equal to " + pricePerPlay.ToString("c2"));
                lstCalc.Items.Add("Streaming total number is " + streamTTL.ToString("c2"));
                lstCalc.Items.Add("Your streaming discount for " + genreName + " is " + genreDiscount.ToString() + "%");



                sw = File.AppendText(MusicLog);
                sw.WriteLine("*********** Beginning of Transaction at " +
                            DateTime.Now.ToString("G") + " **********");
                sw.WriteLine("Song Name is " + songName);
                // updated output
                sw.WriteLine("Song Genre is " + genreName);
                sw.WriteLine("There are  " + songPlays.ToString("C") + "song plays");
                sw.WriteLine("Song cost is equal to " + pricePerPlay.ToString("C2"));
                sw.WriteLine("Streaming total number is  " + streamTTL.ToString("N0"));
                sw.WriteLine("Your streaming discount for " + genreName + " is " + genreDiscount.ToString("P2"));

                sw.Close();


                btnClear.Focus();
            }
            else

            {
                if (!validPricePerPlay)
                {
                    lstCalc.Items.Add("Please enter a numeric entry for price.");
                }
                if (!validSongPlays)
                { lstCalc.Items.Add("Please enter whole numbers for the amount of song plays."); }
            }
        }

        private void txtPlays_Enter(object sender, EventArgs e)
        {
            

        }

        private void txtPlays_Leave(object sender, EventArgs e)
        {
            
        }

        private void rbtnGenre1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnHipHop.Checked)
            {
                genreName = HIPHOP;
            }
        }

        private void txtSong_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSong_Enter(object sender, EventArgs e)
        {
            txtSong.BackColor = Color.Bisque;
        }

        private void txtSong_Leave(object sender, EventArgs e)
        {
            txtSong.BackColor = SystemColors.Window;
        }

        private void txtSongName_Enter(object sender, EventArgs e)
        {
            txtSongName.BackColor = Color.Bisque;
        }

        private void txtSongName_Leave(object sender, EventArgs e)
        {
            txtSongName.BackColor = SystemColors.Window;
        }

        private void lstCalc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSongName_TextChanged(object sender, EventArgs e)
        {
            txtSongName.Focus();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            settingForm = new Form2(this);



            rbtnHipHop.Checked = true;
            StreamReader reader;
            bool valValid;
            bool fileBad = true;
            do
            {
                try
                {
                    reader = File.OpenText(MusicConfig);
                    fileBad = false;
                    
                    
                    valValid = double.TryParse(reader.ReadLine(), out HiphopDiscountRate);
                    valValid = double.TryParse(reader.ReadLine(), out RockDiscountRate);
                    valValid = double.TryParse(reader.ReadLine(), out PopDiscountRate);
                    valValid = double.TryParse(reader.ReadLine(), out JazzDiscountRate);
                    valValid = double.TryParse(reader.ReadLine(), out TechnoDiscountRate);
                    valValid = double.TryParse(reader.ReadLine(), out CountryDiscountRate);


                    reader.Close();
                }
                catch (FileNotFoundException ex)
                {
                    MessageBox.Show("The configuation file was not found. Please select a different file \n Error message was: " +
                        ex.Message
                        );

                    OpenFileDialog openFileDialog1 = new OpenFileDialog();
                    openFileDialog1.InitialDirectory = Application.StartupPath;
                    openFileDialog1.ShowDialog();

                    MusicConfig = openFileDialog1.FileName;
                }
            } while (fileBad);


        }
        private void rbtnRock_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnRock.Checked)
            {
                genreName = ROCK;
            }
        }

        private void rbtnPop_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnPop.Checked)
            {
                genreName = POP;
            }
        }

        private void rbtnCountry_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnCountry.Checked)
            {
                genreName = COUNTRY;
            }
        }

        private void rbtnJazz_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnJazz.Checked)
            {
                genreName = JAZZ;
            }
        }

        private void rbtnTechno_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnTechno.Checked)
            {
                genreName = TECHNO;
            }
        }

        private void btnsettings_Click(object sender, EventArgs e)
        {
            setValuesOnSecondForm();
            settingForm.ShowDialog();
        }

        public void setValuesOnSecondForm()
        {

            settingForm.txtHipHop.Text = HipHop.ToString();
            settingForm.txtRock.Text = Rock.ToString();
            settingForm.txtPop.Text = Pop.ToString();
            settingForm.txtJazz.Text = Jazz.ToString();
            settingForm.txtTechno.Text = Techno.ToString();
            settingForm.txtCountry.Text = Country.ToString();

        }

        private void btnDisplayLog_Click(object sender, EventArgs e)
        {
            const int MAX_LOG_SIZE = 2000;
            string[] MusicLogLines = new string[MAX_LOG_SIZE];
            int numLogLines = 0;
            StreamReader sr;
            sr = File.OpenText(MusicLog);
            while (!sr.EndOfStream)
            {
                MusicLogLines[numLogLines] = sr.ReadLine();
                numLogLines++;
            }
            sr.Close();

            int begTrans = -2;
            int endTrans = 5;

            for (int i = 0; i < numLogLines; i++)
            {
                if (MusicLogLines[i] == "Song Genre is " + genreName)
                {
                    

                    for (int j = i + begTrans; j < i + endTrans; j++)
                    {
                        lstCalc.Items.Add(MusicLogLines[j]);

                    }
                }
            }
        }
    }
}