namespace LoginScreen
{
partial class Form1
{
/// <summary>
/// Required designer variable.
/// </summary>
private System.ComponentModel.IContainer components = null;
/// <summary>
/// Clean up any resources being used.
/// </summary>
/// <param name="disposing">true if managed resources should be disposed; otherwise,
false.</param>
protected override void Dispose(bool disposing)
{
if (disposing && (components != null))
{
components.Dispose();
}
base.Dispose(disposing);
}
#reg/// <summary>
/// Required method for Designer support - do not modify
/// the contents of this method with the code editor.
/// </summary>
private void InitializeComponent()
{
this.label1 = new System.Windows.Forms.Label();
this.label2 = new System.Windows.Forms.Label();
this.txtUsername = new System.Windows.Forms.TextBox();
this.txtPassword = new System.Windows.Forms.TextBox();
this.btnLogin = new System.Windows.Forms.Button();
this.SuspendLayout();
//
// label1
//
this.label1.AutoSize = true;
this.label1.Location = new System.Drawing.Point(12, 15);
this.label1.Name = "label1";
this.label1.Size = new System.Drawing.Size(55, 13);
this.label1.TabIndex = 0;
this.label1.Text = "Username:";
//
// label2
//
this.label2.AutoSize = true;
this.label2.Location = new System.Drawing.Point(12, 41);
this.label2.Name = "label2";this.label2.Size = new System.Drawing.Size(56, 13);
this.label2.TabIndex = 1;
this.label2.Text = "Password:";
//
// txtUsername
//
this.txtUsername.Location = new System.Drawing.Point(73, 12);
this.txtUsername.Name = "txtUsername";
this.txtUsername.Size = new System.Drawing.Size(215, 20);
this.txtUsername.TabIndex = 2;
//
// txtPassword
//
this.txtPassword.Location = new System.Drawing.Point(73, 38);
this.txtPassword.Name = "txtPassword";
this.txtPassword.PasswordChar = '*';
this.txtPassword.Size = new System.Drawing.Size(215, 20);
this.txtPassword.TabIndex = 3;
//
// btnLogin
//
this.btnLogin.Location = new System.Drawing.Point(213, 64);
this.btnLogin.Name = "btnLogin";
this.btnLogin.Size = new System.Drawing.Size(75, 23);
this.btnLogin.TabIndex = 4;
this.btnLogin.Text = "Login";
this.btnLogin.UseVisualStyleBackColor = true;this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
//
// Form1
//
this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
this.ClientSize = new System.Drawing.Size(300, 94);
this.Controls.Add(this.btnLogin);
this.Controls.Add(this.txtPassword);
this.Controls.Add(this.txtUsername);
this.Controls.Add(this.label2);
this.Controls.Add(this.label1);
this.Name = "Form1";
this.Text = "Login Screen";
this.ResumeLayout(false);
this.PerformLayout();
}
#endregion
private System.Windows.Forms.Label label1;
private System.Windows.Forms.Label label2;
private System.Windows.Forms.TextBox txtUsername;
private System.Windows.Forms.TextBox txtPassword;
private System.Windows.Forms.Button btnLogin;
}}