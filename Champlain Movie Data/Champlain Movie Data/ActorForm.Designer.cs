namespace Champlain_Movie_Data
{
    partial class ActorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActorForm));
            System.Windows.Forms.Label actorIdLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label birthYearLabel;
            System.Windows.Forms.Label deathYearLabel;
            this.movieDatabaseDataSet = new Champlain_Movie_Data.MovieDatabaseDataSet();
            this.actorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.actorTableAdapter = new Champlain_Movie_Data.MovieDatabaseDataSetTableAdapters.ActorTableAdapter();
            this.tableAdapterManager = new Champlain_Movie_Data.MovieDatabaseDataSetTableAdapters.TableAdapterManager();
            this.actorBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.actorBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.actorIdTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.birthYearTextBox = new System.Windows.Forms.TextBox();
            this.deathYearTextBox = new System.Windows.Forms.TextBox();
            this.exitButtonActor = new System.Windows.Forms.Button();
            actorIdLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            birthYearLabel = new System.Windows.Forms.Label();
            deathYearLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.movieDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actorBindingNavigator)).BeginInit();
            this.actorBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // movieDatabaseDataSet
            // 
            this.movieDatabaseDataSet.DataSetName = "MovieDatabaseDataSet";
            this.movieDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // actorBindingSource
            // 
            this.actorBindingSource.DataMember = "Actor";
            this.actorBindingSource.DataSource = this.movieDatabaseDataSet;
            // 
            // actorTableAdapter
            // 
            this.actorTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ActorTableAdapter = this.actorTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GenreTableAdapter = null;
            this.tableAdapterManager.MovieGenreTableAdapter = null;
            this.tableAdapterManager.MovieTableAdapter = null;
            this.tableAdapterManager.RoleTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Champlain_Movie_Data.MovieDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // actorBindingNavigator
            // 
            this.actorBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.actorBindingNavigator.BindingSource = this.actorBindingSource;
            this.actorBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.actorBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.actorBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.actorBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.actorBindingNavigatorSaveItem});
            this.actorBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.actorBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.actorBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.actorBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.actorBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.actorBindingNavigator.Name = "actorBindingNavigator";
            this.actorBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.actorBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.actorBindingNavigator.TabIndex = 0;
            this.actorBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // actorBindingNavigatorSaveItem
            // 
            this.actorBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.actorBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("actorBindingNavigatorSaveItem.Image")));
            this.actorBindingNavigatorSaveItem.Name = "actorBindingNavigatorSaveItem";
            this.actorBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.actorBindingNavigatorSaveItem.Text = "Save Data";
            this.actorBindingNavigatorSaveItem.Click += new System.EventHandler(this.actorBindingNavigatorSaveItem_Click);
            // 
            // actorIdLabel
            // 
            actorIdLabel.AutoSize = true;
            actorIdLabel.Location = new System.Drawing.Point(276, 146);
            actorIdLabel.Name = "actorIdLabel";
            actorIdLabel.Size = new System.Drawing.Size(55, 16);
            actorIdLabel.TabIndex = 1;
            actorIdLabel.Text = "Actor Id:";
            // 
            // actorIdTextBox
            // 
            this.actorIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.actorBindingSource, "ActorId", true));
            this.actorIdTextBox.Location = new System.Drawing.Point(360, 143);
            this.actorIdTextBox.Name = "actorIdTextBox";
            this.actorIdTextBox.Size = new System.Drawing.Size(100, 22);
            this.actorIdTextBox.TabIndex = 2;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(276, 174);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(47, 16);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.actorBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(360, 171);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 22);
            this.nameTextBox.TabIndex = 4;
            // 
            // birthYearLabel
            // 
            birthYearLabel.AutoSize = true;
            birthYearLabel.Location = new System.Drawing.Point(276, 202);
            birthYearLabel.Name = "birthYearLabel";
            birthYearLabel.Size = new System.Drawing.Size(68, 16);
            birthYearLabel.TabIndex = 5;
            birthYearLabel.Text = "Birth Year:";
            // 
            // birthYearTextBox
            // 
            this.birthYearTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.actorBindingSource, "BirthYear", true));
            this.birthYearTextBox.Location = new System.Drawing.Point(360, 199);
            this.birthYearTextBox.Name = "birthYearTextBox";
            this.birthYearTextBox.Size = new System.Drawing.Size(100, 22);
            this.birthYearTextBox.TabIndex = 6;
            // 
            // deathYearLabel
            // 
            deathYearLabel.AutoSize = true;
            deathYearLabel.Location = new System.Drawing.Point(276, 230);
            deathYearLabel.Name = "deathYearLabel";
            deathYearLabel.Size = new System.Drawing.Size(78, 16);
            deathYearLabel.TabIndex = 7;
            deathYearLabel.Text = "Death Year:";
            // 
            // deathYearTextBox
            // 
            this.deathYearTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.actorBindingSource, "DeathYear", true));
            this.deathYearTextBox.Location = new System.Drawing.Point(360, 227);
            this.deathYearTextBox.Name = "deathYearTextBox";
            this.deathYearTextBox.Size = new System.Drawing.Size(100, 22);
            this.deathYearTextBox.TabIndex = 8;
            // 
            // exitButtonActor
            // 
            this.exitButtonActor.Location = new System.Drawing.Point(322, 299);
            this.exitButtonActor.Name = "exitButtonActor";
            this.exitButtonActor.Size = new System.Drawing.Size(75, 23);
            this.exitButtonActor.TabIndex = 9;
            this.exitButtonActor.Text = "Exit";
            this.exitButtonActor.UseVisualStyleBackColor = true;
            this.exitButtonActor.Click += new System.EventHandler(this.exitButtonActor_Click);
            // 
            // ActorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitButtonActor);
            this.Controls.Add(actorIdLabel);
            this.Controls.Add(this.actorIdTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(birthYearLabel);
            this.Controls.Add(this.birthYearTextBox);
            this.Controls.Add(deathYearLabel);
            this.Controls.Add(this.deathYearTextBox);
            this.Controls.Add(this.actorBindingNavigator);
            this.Name = "ActorForm";
            this.Text = "ActorForm";
            this.Load += new System.EventHandler(this.ActorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.movieDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actorBindingNavigator)).EndInit();
            this.actorBindingNavigator.ResumeLayout(false);
            this.actorBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MovieDatabaseDataSet movieDatabaseDataSet;
        private System.Windows.Forms.BindingSource actorBindingSource;
        private MovieDatabaseDataSetTableAdapters.ActorTableAdapter actorTableAdapter;
        private MovieDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator actorBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton actorBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox actorIdTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox birthYearTextBox;
        private System.Windows.Forms.TextBox deathYearTextBox;
        private System.Windows.Forms.Button exitButtonActor;
    }
}