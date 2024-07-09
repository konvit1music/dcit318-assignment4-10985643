using System;
using System.Drawing;
using System.Windows.Forms;
namespace DrawingApp
{
public partial class Form1 : Form
{
private Point startPoint;
private Point endPoint;
private bool isDrawing = false;public Form1()
{
InitializeComponent();
}
private void Form1_MouseDown(object sender, MouseEventArgs e)
{
if (e.Button == MouseButtons.Left)
{
isDrawing = true;
startPoint = e.Location;
}
}
private void Form1_MouseMove(object sender, MouseEventArgs e)
{
if (isDrawing)
{
endPoint = e.Location;
using (Graphics graphics = CreateGraphics())
{
graphics.DrawLine(Pens.Black, startPoint, endPoint);
}
startPoint = endPoint;
}
}private void Form1_MouseUp(object sender, MouseEventArgs e)
{
isDrawing = false;
}
}
}
