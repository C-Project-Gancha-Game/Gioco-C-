namespace Login
{
    partial class LoginF1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // textBox1 - Username
            this.textBox1.Location = new System.Drawing.Point(120, 50);
            this.textBox1.Size = new System.Drawing.Size(200, 23);
            this.textBox1.PlaceholderText = "Username";

            // textBox2 - Password
            this.textBox2.Location = new System.Drawing.Point(120, 100);
            this.textBox2.Size = new System.Drawing.Size(200, 23);
            this.textBox2.PasswordChar = '*';
            this.textBox2.PlaceholderText = "Password";

            // button1 - Login
            this.button1.Location = new System.Drawing.Point(160, 150);
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.Text = "Login";
            this.button1.Click += new System.EventHandler(this.button1_Click);

            // Form
            this.ClientSize = new System.Drawing.Size(450, 250);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Text = "Login";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
    }
}