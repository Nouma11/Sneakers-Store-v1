namespace Sneakers_Store_v1
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
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Nike");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Puma");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Adidas");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("New Balance");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Sneakers", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Air Jordan 1");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Nike Air Force 1");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Nike Dunk Low");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Nike Air Max 90");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Nike", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Adidas Yeezy Boost 350", 1, 1);
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Adidas Ultraboost", 1, 1);
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Adidas Samba");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Adidas", 1, 1, new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12,
            treeNode13});
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Puma Suede Classic\n\n", 2, 2);
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Puma RS-X", 2, 2);
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Puma", 2, 2, new System.Windows.Forms.TreeNode[] {
            treeNode15,
            treeNode16});
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("New Balance 550\n\n", 3, 3);
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("New Balance 990v5\n\n", 3, 3);
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("New Balance", 3, 3, new System.Windows.Forms.TreeNode[] {
            treeNode18,
            treeNode19});
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.lbPrice = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.treeView1);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(26, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 290);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sneakers Name";
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(3, 36);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "nike";
            treeNode1.Text = "Nike";
            treeNode2.Name = "puma";
            treeNode2.Text = "Puma";
            treeNode3.Name = "adidas";
            treeNode3.Text = "Adidas";
            treeNode4.Name = "Nbalance";
            treeNode4.Text = "New Balance";
            treeNode5.Name = "Node0";
            treeNode5.Text = "Sneakers";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5});
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(325, 251);
            this.treeView1.TabIndex = 0;
            this.treeView1.DoubleClick += new System.EventHandler(this.treeView1_DoubleClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Sneaker Icon.ico");
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.treeView2);
            this.groupBox2.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(435, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(425, 595);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sneakers Modele";
            // 
            // treeView2
            // 
            this.treeView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView2.ImageIndex = 0;
            this.treeView2.ImageList = this.imageList2;
            this.treeView2.Location = new System.Drawing.Point(3, 36);
            this.treeView2.Name = "treeView2";
            treeNode6.ForeColor = System.Drawing.Color.Red;
            treeNode6.Name = "Node4";
            treeNode6.Text = "Air Jordan 1";
            treeNode7.ForeColor = System.Drawing.Color.Red;
            treeNode7.Name = "Node5";
            treeNode7.Text = "Nike Air Force 1";
            treeNode8.ForeColor = System.Drawing.Color.Red;
            treeNode8.Name = "Node6";
            treeNode8.Text = "Nike Dunk Low";
            treeNode9.ForeColor = System.Drawing.Color.Red;
            treeNode9.Name = "Node7";
            treeNode9.Text = "Nike Air Max 90";
            treeNode10.Name = "Node0";
            treeNode10.SelectedImageIndex = 0;
            treeNode10.Text = "Nike";
            treeNode11.ForeColor = System.Drawing.Color.Blue;
            treeNode11.ImageIndex = 1;
            treeNode11.Name = "Node8";
            treeNode11.SelectedImageIndex = 1;
            treeNode11.Text = "Adidas Yeezy Boost 350";
            treeNode12.ForeColor = System.Drawing.Color.Blue;
            treeNode12.ImageIndex = 1;
            treeNode12.Name = "Node9";
            treeNode12.SelectedImageIndex = 1;
            treeNode12.Text = "Adidas Ultraboost";
            treeNode13.ForeColor = System.Drawing.Color.Blue;
            treeNode13.ImageIndex = 1;
            treeNode13.Name = "Node10";
            treeNode13.Text = "Adidas Samba";
            treeNode14.ForeColor = System.Drawing.Color.Black;
            treeNode14.ImageIndex = 1;
            treeNode14.Name = "Node1";
            treeNode14.SelectedImageIndex = 1;
            treeNode14.Text = "Adidas";
            treeNode15.ForeColor = System.Drawing.Color.Pink;
            treeNode15.ImageIndex = 2;
            treeNode15.Name = "Node11";
            treeNode15.SelectedImageIndex = 2;
            treeNode15.Tag = "Puma Suede Classic\n\n";
            treeNode15.Text = "Puma Suede Classic\n\n";
            treeNode16.ForeColor = System.Drawing.Color.Pink;
            treeNode16.ImageIndex = 2;
            treeNode16.Name = "Node12";
            treeNode16.SelectedImageIndex = 2;
            treeNode16.Text = "Puma RS-X";
            treeNode17.ForeColor = System.Drawing.Color.Black;
            treeNode17.ImageIndex = 2;
            treeNode17.Name = "Node2";
            treeNode17.SelectedImageIndex = 2;
            treeNode17.Text = "Puma";
            treeNode18.ImageIndex = 3;
            treeNode18.Name = "Node13";
            treeNode18.SelectedImageIndex = 3;
            treeNode18.Tag = "New Balance 550\n\n";
            treeNode18.Text = "New Balance 550\n\n";
            treeNode19.ImageIndex = 3;
            treeNode19.Name = "Node14";
            treeNode19.SelectedImageIndex = 3;
            treeNode19.Tag = "New Balance 990v5\n\n";
            treeNode19.Text = "New Balance 990v5\n\n";
            treeNode20.ImageIndex = 3;
            treeNode20.Name = "Node3";
            treeNode20.SelectedImageIndex = 3;
            treeNode20.Text = "New Balance";
            this.treeView2.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode14,
            treeNode17,
            treeNode20});
            this.treeView2.SelectedImageIndex = 0;
            this.treeView2.Size = new System.Drawing.Size(419, 556);
            this.treeView2.TabIndex = 0;
            this.treeView2.DoubleClick += new System.EventHandler(this.treeView2_DoubleClick);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "nike.ico");
            this.imageList2.Images.SetKeyName(1, "adidas.png");
            this.imageList2.Images.SetKeyName(2, "puma.ico");
            this.imageList2.Images.SetKeyName(3, "new balance.png");
            // 
            // pb1
            // 
            this.pb1.Image = ((System.Drawing.Image)(resources.GetObject("pb1.Image")));
            this.pb1.Location = new System.Drawing.Point(902, 111);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(419, 325);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb1.TabIndex = 3;
            this.pb1.TabStop = false;
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbPrice.Location = new System.Drawing.Point(1032, 472);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(158, 79);
            this.lbPrice.TabIndex = 4;
            this.lbPrice.Text = "$115";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1342, 704);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Sneakers Store";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TreeView treeView2;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.Label lbPrice;
    }
}

