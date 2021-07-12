using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Text;
using System.IO;
using System.Drawing.Imaging;

namespace TestBase64
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
       
      
        int i,j;

		private System.Windows.Forms.TextBox txtDecoded;
		private System.Windows.Forms.Button btnEncode;
		private System.Windows.Forms.Button btnDecode;
		private System.Windows.Forms.TextBox txtEncoded;
		private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private PictureBox pictureBox1;
        private Button button4;
        private TextBox txtCurrentPath;
        private Label label3;
        private RichTextBox richTextBox3;
        private OpenFileDialog openFD;
        private PictureBox pictureBox2;
        private Button button7;
        private RichTextBox richTextBox4;
        private RichTextBox richTextBox5;
        private Button button1;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button2;
        private PictureBox pictureBox3;
        private TextBox textBox5;
        private Label label7;
        private IContainer components;

		public Form1()
		{
			InitializeComponent();

			
		}

		
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtDecoded = new System.Windows.Forms.TextBox();
            this.txtEncoded = new System.Windows.Forms.TextBox();
            this.btnEncode = new System.Windows.Forms.Button();
            this.btnDecode = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.txtCurrentPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.openFD = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button7 = new System.Windows.Forms.Button();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.richTextBox5 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDecoded
            // 
            this.txtDecoded.Location = new System.Drawing.Point(41, 50);
            this.txtDecoded.Multiline = true;
            this.txtDecoded.Name = "txtDecoded";
            this.txtDecoded.Size = new System.Drawing.Size(304, 80);
            this.txtDecoded.TabIndex = 0;
            this.txtDecoded.Text = "decoded";
            // 
            // txtEncoded
            // 
            this.txtEncoded.Location = new System.Drawing.Point(112, 116);
            this.txtEncoded.Multiline = true;
            this.txtEncoded.Name = "txtEncoded";
            this.txtEncoded.Size = new System.Drawing.Size(58, 38);
            this.txtEncoded.TabIndex = 1;
            this.txtEncoded.Text = "encoded";
            this.txtEncoded.Visible = false;
            // 
            // btnEncode
            // 
            this.btnEncode.BackColor = System.Drawing.Color.White;
            this.btnEncode.Location = new System.Drawing.Point(146, 136);
            this.btnEncode.Name = "btnEncode";
            this.btnEncode.Size = new System.Drawing.Size(104, 23);
            this.btnEncode.TabIndex = 2;
            this.btnEncode.Text = "Encode";
            this.btnEncode.UseVisualStyleBackColor = false;
            this.btnEncode.Click += new System.EventHandler(this.btnEncode_Click);
            // 
            // btnDecode
            // 
            this.btnDecode.BackColor = System.Drawing.Color.White;
            this.btnDecode.Location = new System.Drawing.Point(517, 136);
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Size = new System.Drawing.Size(75, 23);
            this.btnDecode.TabIndex = 3;
            this.btnDecode.Text = "Decode";
            this.btnDecode.UseVisualStyleBackColor = false;
            this.btnDecode.Click += new System.EventHandler(this.btnDecode_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(146, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Original Text";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(523, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "KSCII Code";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(402, 50);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(304, 80);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "encoded";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(882, 109);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(57, 42);
            this.textBox2.TabIndex = 1;
            this.textBox2.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Location = new System.Drawing.Point(41, 191);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(196, 203);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(127, 30);
            this.button4.TabIndex = 14;
            this.button4.Text = "&Open File...";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtCurrentPath
            // 
            this.txtCurrentPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCurrentPath.Location = new System.Drawing.Point(251, 172);
            this.txtCurrentPath.Name = "txtCurrentPath";
            this.txtCurrentPath.ReadOnly = true;
            this.txtCurrentPath.Size = new System.Drawing.Size(275, 13);
            this.txtCurrentPath.TabIndex = 16;
            this.txtCurrentPath.Text = "(none)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Current Path:";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(32, 251);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(288, 253);
            this.richTextBox3.TabIndex = 17;
            this.richTextBox3.Text = "";
            this.richTextBox3.Visible = false;
            // 
            // openFD
            // 
            this.openFD.FileName = "openFileDialog1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(801, 176);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(94, 57);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(41, 527);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 21;
            this.button7.Text = "reimage";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Visible = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // richTextBox4
            // 
            this.richTextBox4.Location = new System.Drawing.Point(72, 251);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(298, 253);
            this.richTextBox4.TabIndex = 22;
            this.richTextBox4.Text = "";
            // 
            // richTextBox5
            // 
            this.richTextBox5.Location = new System.Drawing.Point(746, 251);
            this.richTextBox5.Name = "richTextBox5";
            this.richTextBox5.Size = new System.Drawing.Size(298, 253);
            this.richTextBox5.TabIndex = 24;
            this.richTextBox5.Text = "";
            this.richTextBox5.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(163, 527);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "reimage";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(529, 293);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(177, 20);
            this.textBox3.TabIndex = 26;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(529, 351);
            this.textBox4.Name = "textBox4";
            this.textBox4.PasswordChar = '*';
            this.textBox4.Size = new System.Drawing.Size(177, 20);
            this.textBox4.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(399, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 23);
            this.label4.TabIndex = 28;
            this.label4.Text = "USER NAME";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(399, 348);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 23);
            this.label5.TabIndex = 29;
            this.label5.Text = "PASSWORD";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(580, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 23);
            this.label6.TabIndex = 30;
            this.label6.Text = "LOGIN";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(563, 404);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 31;
            this.button2.Text = "VIEW";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Location = new System.Drawing.Point(403, 191);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 32;
            this.pictureBox3.TabStop = false;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(464, 527);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(484, 491);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "RANDOM";
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(740, 562);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox5);
            this.Controls.Add(this.richTextBox4);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.txtCurrentPath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDecode);
            this.Controls.Add(this.btnEncode);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtEncoded);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtDecoded);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "IMAGE ENCYPTOR";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void btnEncode_Click(object sender, System.EventArgs e)
		{
			//first get the bytes for the original
			byte[] data=System.Text.UnicodeEncoding.UTF8.GetBytes(txtDecoded.Text);
			Base64Encoder myEncoder=new Base64Encoder(data);
			StringBuilder sb=new StringBuilder();

			sb.Append(myEncoder.GetEncoded());

			txtEncoded.Text=sb.ToString();

            string a, m = "";
            string[] b = new string[9000];
            long[] c = new long[9999];
            a = txtEncoded.Text;
            for (i = 0; i <= a.Length - 1; i++)
            {
                c[i] = Convert.ToInt64(a[i]) + 41;
                if (b[i] == " ")
                    b[i] = Convert.ToString(a[i]);
                else
                    b[i] = b[i] + Convert.ToString(c[i]);
            }

            for (i = 0; i <= a.Length - 1; i++)
            {
                m = m + b[i] + ".";
            }
            textBox1.Text = m.ToString();
		}

		private void btnDecode_Click(object sender, System.EventArgs e)
		{
            string a, n = "";
            string[] o1 = new string[1000];
            long[] c = new long[9999];
            string[] b = new string[9000];
            string[] t = new string[9000];
            string[] p = new string[9000];
            a = textBox1.Text;
            b[j] = "";
            for (i = 0, j = 0; i <= a.Length - 1; i++)
            {
                t[i] = Convert.ToString(a[i]);
                if (t[i] == ".")
                {
                    b[j] = Convert.ToString(t[i]);
                    ++j;
                }
                else
                    p[j] = p[j] + t[i];
            }
            for (i = 0; i < j; i++)
            {
                c[i] = Convert.ToInt64(p[i]) - 41;
                o1[i] = Convert.ToString(Convert.ToChar(c[i]));
                n = n + o1[i].ToString();
            }
            textBox2.Text = n.ToString();

			char[] data=textBox2.Text.ToCharArray();
			Base64Decoder myDecoder=new Base64Decoder(data);
			StringBuilder sb=new StringBuilder();

			byte[] temp=myDecoder.GetDecoded();
			sb.Append(System.Text.UTF8Encoding.UTF8.GetChars(temp));

			txtDecoded.Text=sb.ToString();


           
		}
        public string FileToBase64String(string path)
        {
            FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
            byte[] buffer = new byte[fileStream.Length];
            fileStream.Read(buffer, 0, (int)fileStream.Length);

            MemoryStream memory = new MemoryStream(buffer);
            string base64 = Convert.ToBase64String(memory.ToArray());
            memory.Close();

            return base64;
        }
        public string ImageToBase64String(Image image, ImageFormat format)
        {
            MemoryStream memory = new MemoryStream();
            image.Save(memory, image.RawFormat);
            string base64 = Convert.ToBase64String(memory.ToArray());
            memory.Close();

            return base64;
        }
        public string IconToBase64String(Icon image)
        {
            MemoryStream memory = new MemoryStream();
            image.Save(memory);
            string base64 = Convert.ToBase64String(memory.ToArray());
            memory.Close();

            return base64;
        }

        // The following methods can be used to reverse this process.
        public Image ImageFromBase64String(string base64)
        {
            MemoryStream memory = new MemoryStream(Convert.FromBase64String(base64));
            Image result = Image.FromStream(memory);
            memory.Close();

            return result;
        }
        public Icon IconFromBase64String(string base64)
        {
            MemoryStream memory = new MemoryStream(Convert.FromBase64String(base64));
            Icon result = new Icon(memory);
            memory.Close();

            return result;
        }
        public Cursor CursorFromBase64String(string base64)
        {
            MemoryStream memory = new MemoryStream(Convert.FromBase64String(base64));
            Cursor result = new Cursor(memory);
            memory.Close();

            return result;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDlg = new OpenFileDialog();
            openDlg.Filter = "All Supported Files (*.gif;*.jpg;*.jpeg;*.bmp;*.wmf;*.png;*.ico;*.cur)|*.gif;*.jpg;*.jpeg;*.bmp;*.wmf;*.png;*.ico;*.cur|Image Files (*.gif;*.jpg;*.jpeg;*.bmp;*.wmf;*.png)|*.gif;*.jpg;*.jpeg;*.bmp;*.wmf;*.png|Icon Files (*.ico;*.cur)|*.ico;*.cur|All Files (*.*)|*.*";

            if (openDlg.ShowDialog(this) == DialogResult.OK)
            {
                Cursor = Cursors.WaitCursor;

                try
                {
                    txtCurrentPath.Text = openDlg.FileName;
                    pictureBox1.Image = Image.FromFile(openDlg.FileName);
                    pictureBox1.Visible = true;
                }
                catch (Exception)
                {
                    pictureBox1.Image = null;
                    pictureBox1.Visible = false;
                }

                // lblNotImage.Visible = !pictureBox1.Visible;

                try
                {
                    richTextBox3.Text = FileToBase64String(openDlg.FileName);
                }
                catch (Exception)
                {
                    MessageBox.Show(this, string.Format("An error occurred whilst converting to base-64."),
                        Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                Cursor = Cursors.Default;
            }


            string a, m = "";
            string[] b = new string[9223372036854775807];
            long[] c = new long[9223372036854775806];
            a = richTextBox3.Text;
            for (i = 0; i <= a.Length - 1; i++)
            {
                c[i] = Convert.ToInt64(a[i]) + 41;
                if (b[i] == " ")
                    b[i] = Convert.ToString(a[i]);
                else
                    b[i] = b[i] + Convert.ToString(c[i]);
            }

            for (i = 0; i <= a.Length - 1; i++)
            {
                m = m + b[i] + ".";
            }
            richTextBox4.Text = m.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                pictureBox2.Image = ImageFromBase64String(richTextBox3.Text);
            }
            catch (Exception)
            {
                MessageBox.Show(this, string.Format("An error occurred base64 string converting to image."),
                    Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

     

        private void button1_Click(object sender, EventArgs e)
        {
            string a, n = "";
            string[] o1 = new string[9223372036854775807];
           long[] c = new long[9223372036854775806];
           string[] b = new string[9223372036854775807];
           string[] t = new string[9223372036854775807];
           string[] p = new string[9223372036854775807];
            
            a = richTextBox4.Text;
            b[j] = "";
            for (i = 0, j = 0; i <= a.Length - 1; i++)
            {
                t[i] = Convert.ToString(a[i]);
                if (t[i] == ".")
                {
                    b[j] = Convert.ToString(t[i]);
                    ++j;
                }
                else
                    p[j] = p[j] + t[i];
            }
            for (i = 0; i < j; i++)
            {
                c[i] = Convert.ToInt64(p[i]) - 41;
                o1[i] = Convert.ToString(Convert.ToChar(c[i]));
                n = n + o1[i].ToString();
            }
            richTextBox5.Text = n.ToString();       


            try
            {
                pictureBox3.Image = ImageFromBase64String(richTextBox5.Text);
            }
            catch (Exception)
            {
                MessageBox.Show(this, string.Format("An error occurred base64 string converting to image."),
                    Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            btnDecode.Enabled = false;
            btnEncode.Enabled = false;
            button4.Enabled = false;
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox3.Text.Equals(textBox4.Text))
            {
                btnDecode.Enabled = true;
                btnEncode.Enabled = true;
                button4.Enabled = true;
                button1.Enabled = true;
            }
            else
                MessageBox.Show(this, string.Format("Wrong ID"),
                      Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

      
     
       
        }
      
	}

