namespace PovezaneTabele2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Dijaki = new System.Windows.Forms.TabPage();
            this.Izposoja = new System.Windows.Forms.TabPage();
            this.izposojaCDjevDataSet = new PovezaneTabele2.izposojaCDjevDataSet();
            this.dIJAKIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dIJAKITableAdapter = new PovezaneTabele2.izposojaCDjevDataSetTableAdapters.DIJAKITableAdapter();
            this.tableAdapterManager = new PovezaneTabele2.izposojaCDjevDataSetTableAdapters.TableAdapterManager();
            this.dIJAKIBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.dIJAKIBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dIJAKIDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iZPOSOJABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iZPOSOJATableAdapter = new PovezaneTabele2.izposojaCDjevDataSetTableAdapters.IZPOSOJATableAdapter();
            this.iZPOSOJADataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.Dijaki.SuspendLayout();
            this.Izposoja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.izposojaCDjevDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIJAKIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIJAKIBindingNavigator)).BeginInit();
            this.dIJAKIBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dIJAKIDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iZPOSOJABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iZPOSOJADataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Dijaki);
            this.tabControl1.Controls.Add(this.Izposoja);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // Dijaki
            // 
            this.Dijaki.Controls.Add(this.dIJAKIBindingNavigator);
            this.Dijaki.Controls.Add(this.dIJAKIDataGridView);
            this.Dijaki.Location = new System.Drawing.Point(4, 22);
            this.Dijaki.Name = "Dijaki";
            this.Dijaki.Padding = new System.Windows.Forms.Padding(3);
            this.Dijaki.Size = new System.Drawing.Size(792, 424);
            this.Dijaki.TabIndex = 0;
            this.Dijaki.Text = "Dijaki";
            this.Dijaki.UseVisualStyleBackColor = true;
            // 
            // Izposoja
            // 
            this.Izposoja.AutoScroll = true;
            this.Izposoja.Controls.Add(this.iZPOSOJADataGridView);
            this.Izposoja.Location = new System.Drawing.Point(4, 22);
            this.Izposoja.Name = "Izposoja";
            this.Izposoja.Padding = new System.Windows.Forms.Padding(3);
            this.Izposoja.Size = new System.Drawing.Size(792, 424);
            this.Izposoja.TabIndex = 1;
            this.Izposoja.Text = "Izposoja";
            this.Izposoja.UseVisualStyleBackColor = true;
            // 
            // izposojaCDjevDataSet
            // 
            this.izposojaCDjevDataSet.DataSetName = "izposojaCDjevDataSet";
            this.izposojaCDjevDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dIJAKIBindingSource
            // 
            this.dIJAKIBindingSource.DataMember = "DIJAKI";
            this.dIJAKIBindingSource.DataSource = this.izposojaCDjevDataSet;
            // 
            // dIJAKITableAdapter
            // 
            this.dIJAKITableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DIJAKITableAdapter = this.dIJAKITableAdapter;
            this.tableAdapterManager.UpdateOrder = PovezaneTabele2.izposojaCDjevDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dIJAKIBindingNavigator
            // 
            this.dIJAKIBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.dIJAKIBindingNavigator.BindingSource = this.dIJAKIBindingSource;
            this.dIJAKIBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.dIJAKIBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.dIJAKIBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.dIJAKIBindingNavigatorSaveItem});
            this.dIJAKIBindingNavigator.Location = new System.Drawing.Point(3, 3);
            this.dIJAKIBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.dIJAKIBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.dIJAKIBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.dIJAKIBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.dIJAKIBindingNavigator.Name = "dIJAKIBindingNavigator";
            this.dIJAKIBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.dIJAKIBindingNavigator.Size = new System.Drawing.Size(786, 25);
            this.dIJAKIBindingNavigator.TabIndex = 1;
            this.dIJAKIBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // dIJAKIBindingNavigatorSaveItem
            // 
            this.dIJAKIBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.dIJAKIBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("dIJAKIBindingNavigatorSaveItem.Image")));
            this.dIJAKIBindingNavigatorSaveItem.Name = "dIJAKIBindingNavigatorSaveItem";
            this.dIJAKIBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.dIJAKIBindingNavigatorSaveItem.Text = "Save Data";
            this.dIJAKIBindingNavigatorSaveItem.Click += new System.EventHandler(this.dIJAKIBindingNavigatorSaveItem_Click);
            // 
            // dIJAKIDataGridView
            // 
            this.dIJAKIDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dIJAKIDataGridView.AutoGenerateColumns = false;
            this.dIJAKIDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dIJAKIDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dIJAKIDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dIJAKIDataGridView.DataSource = this.dIJAKIBindingSource;
            this.dIJAKIDataGridView.Location = new System.Drawing.Point(3, 31);
            this.dIJAKIDataGridView.Name = "dIJAKIDataGridView";
            this.dIJAKIDataGridView.Size = new System.Drawing.Size(786, 390);
            this.dIJAKIDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "SIFRA";
            this.dataGridViewTextBoxColumn1.HeaderText = "SIFRA";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IME";
            this.dataGridViewTextBoxColumn2.HeaderText = "IME";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PRIIMEK";
            this.dataGridViewTextBoxColumn3.HeaderText = "PRIIMEK";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NASLOV";
            this.dataGridViewTextBoxColumn4.HeaderText = "NASLOV";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "POSTA";
            this.dataGridViewTextBoxColumn5.HeaderText = "POSTA";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "KRAJ";
            this.dataGridViewTextBoxColumn6.HeaderText = "KRAJ";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // iZPOSOJABindingSource
            // 
            this.iZPOSOJABindingSource.DataMember = "DIJAKI_IZPOSOJA";
            this.iZPOSOJABindingSource.DataSource = this.dIJAKIBindingSource;
            // 
            // iZPOSOJATableAdapter
            // 
            this.iZPOSOJATableAdapter.ClearBeforeFill = true;
            // 
            // iZPOSOJADataGridView
            // 
            this.iZPOSOJADataGridView.AutoGenerateColumns = false;
            this.iZPOSOJADataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.iZPOSOJADataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.iZPOSOJADataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.iZPOSOJADataGridView.DataSource = this.iZPOSOJABindingSource;
            this.iZPOSOJADataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iZPOSOJADataGridView.Location = new System.Drawing.Point(3, 3);
            this.iZPOSOJADataGridView.Name = "iZPOSOJADataGridView";
            this.iZPOSOJADataGridView.Size = new System.Drawing.Size(786, 418);
            this.iZPOSOJADataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "SIFRA_DIJAKA";
            this.dataGridViewTextBoxColumn7.HeaderText = "SIFRA_DIJAKA";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "SIFRA_CDJA";
            this.dataGridViewTextBoxColumn8.HeaderText = "SIFRA_CDJA";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "NASLOV";
            this.dataGridViewTextBoxColumn9.HeaderText = "NASLOV";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "IZVAJALEC";
            this.dataGridViewTextBoxColumn10.HeaderText = "IZVAJALEC";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "DATUM_IZPOSOJE";
            this.dataGridViewTextBoxColumn11.HeaderText = "DATUM_IZPOSOJE";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "DATUM_VRNITVE";
            this.dataGridViewTextBoxColumn12.HeaderText = "DATUM_VRNITVE";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.Dijaki.ResumeLayout(false);
            this.Dijaki.PerformLayout();
            this.Izposoja.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.izposojaCDjevDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIJAKIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIJAKIBindingNavigator)).EndInit();
            this.dIJAKIBindingNavigator.ResumeLayout(false);
            this.dIJAKIBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dIJAKIDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iZPOSOJABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iZPOSOJADataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Dijaki;
        private System.Windows.Forms.TabPage Izposoja;
        private izposojaCDjevDataSet izposojaCDjevDataSet;
        private System.Windows.Forms.BindingSource dIJAKIBindingSource;
        private izposojaCDjevDataSetTableAdapters.DIJAKITableAdapter dIJAKITableAdapter;
        private izposojaCDjevDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator dIJAKIBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton dIJAKIBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView dIJAKIDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.BindingSource iZPOSOJABindingSource;
        private izposojaCDjevDataSetTableAdapters.IZPOSOJATableAdapter iZPOSOJATableAdapter;
        private System.Windows.Forms.DataGridView iZPOSOJADataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
    }
}

