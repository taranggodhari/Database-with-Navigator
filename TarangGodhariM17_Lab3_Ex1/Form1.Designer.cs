namespace TarangGodhariM17_Lab3_Ex1
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
            System.Windows.Forms.Label currentMajorLabel;
            System.Windows.Forms.Label favouriteSubjectLabel;
            System.Windows.Forms.Label learnerIDLabel;
            System.Windows.Forms.Label learnerNameLabel;
            System.Windows.Forms.Label strongestSkillLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.browseAllButton = new System.Windows.Forms.Button();
            this.findGroupBox = new System.Windows.Forms.GroupBox();
            this.findButton = new System.Windows.Forms.Button();
            this.findTextBox = new System.Windows.Forms.TextBox();
            this.findLabel = new System.Windows.Forms.Label();
            this.currentMajorTextBox = new System.Windows.Forms.TextBox();
            this.favouriteSubjectTextBox = new System.Windows.Forms.TextBox();
            this.learnerIDTextBox = new System.Windows.Forms.TextBox();
            this.learnerNameTextBox = new System.Windows.Forms.TextBox();
            this.strongestSkillTextBox = new System.Windows.Forms.TextBox();
            this.studentBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.studentBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.updateButton = new System.Windows.Forms.Button();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            currentMajorLabel = new System.Windows.Forms.Label();
            favouriteSubjectLabel = new System.Windows.Forms.Label();
            learnerIDLabel = new System.Windows.Forms.Label();
            learnerNameLabel = new System.Windows.Forms.Label();
            strongestSkillLabel = new System.Windows.Forms.Label();
            this.findGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingNavigator)).BeginInit();
            this.studentBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // currentMajorLabel
            // 
            currentMajorLabel.AutoSize = true;
            currentMajorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            currentMajorLabel.Location = new System.Drawing.Point(17, 94);
            currentMajorLabel.Name = "currentMajorLabel";
            currentMajorLabel.Size = new System.Drawing.Size(87, 13);
            currentMajorLabel.TabIndex = 12;
            currentMajorLabel.Text = "Current Major:";
            // 
            // favouriteSubjectLabel
            // 
            favouriteSubjectLabel.AutoSize = true;
            favouriteSubjectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            favouriteSubjectLabel.Location = new System.Drawing.Point(17, 146);
            favouriteSubjectLabel.Name = "favouriteSubjectLabel";
            favouriteSubjectLabel.Size = new System.Drawing.Size(111, 13);
            favouriteSubjectLabel.TabIndex = 14;
            favouriteSubjectLabel.Text = "Favourite Subject:";
            // 
            // learnerIDLabel
            // 
            learnerIDLabel.AutoSize = true;
            learnerIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            learnerIDLabel.Location = new System.Drawing.Point(17, 42);
            learnerIDLabel.Name = "learnerIDLabel";
            learnerIDLabel.Size = new System.Drawing.Size(71, 13);
            learnerIDLabel.TabIndex = 16;
            learnerIDLabel.Text = "Learner ID:";
            // 
            // learnerNameLabel
            // 
            learnerNameLabel.AutoSize = true;
            learnerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            learnerNameLabel.Location = new System.Drawing.Point(17, 68);
            learnerNameLabel.Name = "learnerNameLabel";
            learnerNameLabel.Size = new System.Drawing.Size(90, 13);
            learnerNameLabel.TabIndex = 18;
            learnerNameLabel.Text = "Learner Name:";
            // 
            // strongestSkillLabel
            // 
            strongestSkillLabel.AutoSize = true;
            strongestSkillLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            strongestSkillLabel.Location = new System.Drawing.Point(17, 120);
            strongestSkillLabel.Name = "strongestSkillLabel";
            strongestSkillLabel.Size = new System.Drawing.Size(93, 13);
            strongestSkillLabel.TabIndex = 20;
            strongestSkillLabel.Text = "Strongest Skill:";
            // 
            // browseAllButton
            // 
            this.browseAllButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.browseAllButton.FlatAppearance.BorderSize = 2;
            this.browseAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseAllButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseAllButton.Location = new System.Drawing.Point(20, 290);
            this.browseAllButton.Name = "browseAllButton";
            this.browseAllButton.Size = new System.Drawing.Size(312, 42);
            this.browseAllButton.TabIndex = 11;
            this.browseAllButton.Text = "Browse All Entries";
            this.browseAllButton.UseVisualStyleBackColor = true;
            this.browseAllButton.Click += new System.EventHandler(this.browseAllButton_Click);
            // 
            // findGroupBox
            // 
            this.findGroupBox.Controls.Add(this.findButton);
            this.findGroupBox.Controls.Add(this.findTextBox);
            this.findGroupBox.Controls.Add(this.findLabel);
            this.findGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findGroupBox.ForeColor = System.Drawing.Color.White;
            this.findGroupBox.Location = new System.Drawing.Point(20, 218);
            this.findGroupBox.Name = "findGroupBox";
            this.findGroupBox.Size = new System.Drawing.Size(312, 56);
            this.findGroupBox.TabIndex = 12;
            this.findGroupBox.TabStop = false;
            this.findGroupBox.Text = "Find an entry by last name";
            // 
            // findButton
            // 
            this.findButton.FlatAppearance.BorderSize = 2;
            this.findButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.findButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findButton.Location = new System.Drawing.Point(180, 15);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(126, 33);
            this.findButton.TabIndex = 1;
            this.findButton.Text = "Find";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // findTextBox
            // 
            this.findTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findTextBox.Location = new System.Drawing.Point(75, 19);
            this.findTextBox.Name = "findTextBox";
            this.findTextBox.Size = new System.Drawing.Size(100, 20);
            this.findTextBox.TabIndex = 0;
            // 
            // findLabel
            // 
            this.findLabel.AutoSize = true;
            this.findLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findLabel.Location = new System.Drawing.Point(7, 22);
            this.findLabel.Name = "findLabel";
            this.findLabel.Size = new System.Drawing.Size(71, 13);
            this.findLabel.TabIndex = 0;
            this.findLabel.Text = "Last Name:";
            // 
            // currentMajorTextBox
            // 
            this.currentMajorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "currentMajor", true));
            this.currentMajorTextBox.Location = new System.Drawing.Point(132, 91);
            this.currentMajorTextBox.Name = "currentMajorTextBox";
            this.currentMajorTextBox.Size = new System.Drawing.Size(200, 20);
            this.currentMajorTextBox.TabIndex = 13;
            // 
            // favouriteSubjectTextBox
            // 
            this.favouriteSubjectTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "favouriteSubject", true));
            this.favouriteSubjectTextBox.Location = new System.Drawing.Point(132, 143);
            this.favouriteSubjectTextBox.Name = "favouriteSubjectTextBox";
            this.favouriteSubjectTextBox.Size = new System.Drawing.Size(200, 20);
            this.favouriteSubjectTextBox.TabIndex = 15;
            // 
            // learnerIDTextBox
            // 
            this.learnerIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "learnerID", true));
            this.learnerIDTextBox.Location = new System.Drawing.Point(132, 39);
            this.learnerIDTextBox.Name = "learnerIDTextBox";
            this.learnerIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.learnerIDTextBox.TabIndex = 17;
            // 
            // learnerNameTextBox
            // 
            this.learnerNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "learnerName", true));
            this.learnerNameTextBox.Location = new System.Drawing.Point(132, 65);
            this.learnerNameTextBox.Name = "learnerNameTextBox";
            this.learnerNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.learnerNameTextBox.TabIndex = 19;
            // 
            // strongestSkillTextBox
            // 
            this.strongestSkillTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "strongestSkill", true));
            this.strongestSkillTextBox.Location = new System.Drawing.Point(132, 117);
            this.strongestSkillTextBox.Name = "strongestSkillTextBox";
            this.strongestSkillTextBox.Size = new System.Drawing.Size(200, 20);
            this.strongestSkillTextBox.TabIndex = 21;
            // 
            // studentBindingNavigator
            // 
            this.studentBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.studentBindingNavigator.BackColor = System.Drawing.SystemColors.Control;
            this.studentBindingNavigator.BindingSource = this.studentBindingSource;
            this.studentBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.studentBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.studentBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.studentBindingNavigatorSaveItem});
            this.studentBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.studentBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.studentBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.studentBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.studentBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.studentBindingNavigator.Name = "studentBindingNavigator";
            this.studentBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.studentBindingNavigator.Size = new System.Drawing.Size(350, 25);
            this.studentBindingNavigator.TabIndex = 22;
            this.studentBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bindingNavigatorCountItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.BackColor = System.Drawing.SystemColors.Info;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // studentBindingNavigatorSaveItem
            // 
            this.studentBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.studentBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("studentBindingNavigatorSaveItem.Image")));
            this.studentBindingNavigatorSaveItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.studentBindingNavigatorSaveItem.Name = "studentBindingNavigatorSaveItem";
            this.studentBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.studentBindingNavigatorSaveItem.Text = "Save";
            this.studentBindingNavigatorSaveItem.Click += new System.EventHandler(this.studentBindingNavigatorSaveItem_Click);
            // 
            // updateButton
            // 
            this.updateButton.FlatAppearance.BorderSize = 2;
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(132, 178);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(200, 34);
            this.updateButton.TabIndex = 23;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(TarangGodhariM17_Lab3_Ex1.TarangTB);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(350, 351);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.studentBindingNavigator);
            this.Controls.Add(currentMajorLabel);
            this.Controls.Add(this.currentMajorTextBox);
            this.Controls.Add(favouriteSubjectLabel);
            this.Controls.Add(this.favouriteSubjectTextBox);
            this.Controls.Add(learnerIDLabel);
            this.Controls.Add(this.learnerIDTextBox);
            this.Controls.Add(learnerNameLabel);
            this.Controls.Add(this.learnerNameTextBox);
            this.Controls.Add(strongestSkillLabel);
            this.Controls.Add(this.strongestSkillTextBox);
            this.Controls.Add(this.browseAllButton);
            this.Controls.Add(this.findGroupBox);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "Form1";
            this.Text = "Student Information";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.findGroupBox.ResumeLayout(false);
            this.findGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingNavigator)).EndInit();
            this.studentBindingNavigator.ResumeLayout(false);
            this.studentBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.Button browseAllButton;
        private System.Windows.Forms.GroupBox findGroupBox;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.TextBox findTextBox;
        private System.Windows.Forms.Label findLabel;
        private System.Windows.Forms.TextBox currentMajorTextBox;
        private System.Windows.Forms.TextBox favouriteSubjectTextBox;
        private System.Windows.Forms.TextBox learnerIDTextBox;
        private System.Windows.Forms.TextBox learnerNameTextBox;
        private System.Windows.Forms.TextBox strongestSkillTextBox;
        private System.Windows.Forms.BindingNavigator studentBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton studentBindingNavigatorSaveItem;
        private System.Windows.Forms.Button updateButton;
    }
}

