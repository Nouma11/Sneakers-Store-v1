using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sneakers_Store_v1
{
    public partial class Form1: Form
    {
        private string _Modele, _Path, _Price;
        private string FileName = @"C:\Users\Med Amine\source\Window Form\Sneakers Store\Modeles.txt";

        private void treeView1_DoubleClick(object sender, EventArgs e)
        {
            treeView2.Nodes.Clear();
            if (treeView1.SelectedNode.Text == "Nike")
            {
                TreeNode parentNode1 = new TreeNode("Nike");
                TreeNode childNode1= new TreeNode("Air Jordan 1");
                TreeNode childNode2 = new TreeNode("Nike Air Force 1");
                TreeNode childNode3 = new TreeNode("Nike Dunk Low");
                TreeNode childNode4 = new TreeNode("Nike Air Max 90");
                treeView2.Nodes.Add(parentNode1);
                parentNode1.Nodes.Add(childNode1);
                parentNode1.Nodes.Add(childNode2);
                parentNode1.Nodes.Add(childNode3);
                parentNode1.Nodes.Add(childNode4);
              
               
                

            }
            else if (treeView1.SelectedNode.Text == "Adidas")
            {
                TreeNode parentNode1 = new TreeNode("Adidas");
                TreeNode childNode1 = new TreeNode("Adidas Yeezy Boost 350");
                TreeNode childNode2 = new TreeNode("Adidas Ultraboost");
                TreeNode childNode3 = new TreeNode("Adidas Samba");
                treeView2.Nodes.Add(parentNode1);
                parentNode1.Nodes.Add(childNode1);
                parentNode1.Nodes.Add(childNode2);
                parentNode1.Nodes.Add(childNode3);
                parentNode1.SelectedImageIndex = 1;
                parentNode1.ImageIndex = 1;
                childNode1.SelectedImageIndex = 1;
                childNode1.ImageIndex = 1;
                childNode2.SelectedImageIndex = 1;
                childNode2.ImageIndex = 1;
                childNode3.SelectedImageIndex = 1;
                childNode3.ImageIndex = 1;


            }
            else if (treeView1.SelectedNode.Text == "Puma")
            {
                TreeNode parentNode1 = new TreeNode("Puma");
                TreeNode childNode1 = new TreeNode("Puma Suede Classic");
                TreeNode childNode2 = new TreeNode("Puma RS-X");
                treeView2.Nodes.Add(parentNode1);
                parentNode1.Nodes.Add(childNode1);
                parentNode1.Nodes.Add(childNode2);
                parentNode1.SelectedImageIndex = 2;
                parentNode1.ImageIndex = 2;
                childNode1.SelectedImageIndex = 2;
                childNode1.ImageIndex = 2;
                childNode2.SelectedImageIndex =2;
                childNode2.ImageIndex =2;

            }
            else
            {
                TreeNode parentNode1 = new TreeNode("New Balance");
                TreeNode childNode1 = new TreeNode("New Balance 550");
                TreeNode childNode2 = new TreeNode("New Balance 990v5");
                treeView2.Nodes.Add(parentNode1);
                parentNode1.Nodes.Add(childNode1);
                parentNode1.Nodes.Add(childNode2);
                parentNode1.SelectedImageIndex = 3;
                parentNode1.ImageIndex = 3;
                childNode1.SelectedImageIndex = 3;
                childNode1.ImageIndex = 3;
                childNode2.SelectedImageIndex = 3;
                childNode2.ImageIndex = 3;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void treeView2_DoubleClick(object sender, EventArgs e)
        {
            var Lines = File.ReadAllLines(FileName);
            string result = treeView2.SelectedNode.Text.Replace("\n", "");
            foreach (string Line in Lines)
            {
                string[] Content = Line.Split('#');
                if (Content[0] == result.Trim() )
                {
                    pb1.Image = Image.FromFile(Content[2]);
                    lbPrice.Text = Content[1];
                    return;
                }
            }
        }

         
         
    }
}
