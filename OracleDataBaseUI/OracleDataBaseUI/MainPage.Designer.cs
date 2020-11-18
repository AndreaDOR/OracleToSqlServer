namespace OracleDataBaseUI
{
    partial class MainPage
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.DatabaseListView = new System.Windows.Forms.ListView();
            this.TableStructView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TableDataView = new System.Windows.Forms.ListView();
            this.ChangeDatabaseBut = new System.Windows.Forms.Button();
            this.ImportDatabaseBut = new System.Windows.Forms.Button();
            this.BackUpButBak = new System.Windows.Forms.Button();
            this.ExitBut = new System.Windows.Forms.Button();
            this.CreateTableToBut = new System.Windows.Forms.Button();
            this.BackUpButDmp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DatabaseListView
            // 
            this.DatabaseListView.GridLines = true;
            this.DatabaseListView.HideSelection = false;
            this.DatabaseListView.Location = new System.Drawing.Point(11, 11);
            this.DatabaseListView.MultiSelect = false;
            this.DatabaseListView.Name = "DatabaseListView";
            this.DatabaseListView.Size = new System.Drawing.Size(188, 537);
            this.DatabaseListView.TabIndex = 0;
            this.DatabaseListView.UseCompatibleStateImageBehavior = false;
            this.DatabaseListView.View = System.Windows.Forms.View.Tile;
            this.DatabaseListView.SelectedIndexChanged += new System.EventHandler(this.DatabaseListView_SelectedIndexChanged);
            // 
            // TableStructView
            // 
            this.TableStructView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader6});
            this.TableStructView.GridLines = true;
            this.TableStructView.HideSelection = false;
            this.TableStructView.Location = new System.Drawing.Point(196, 11);
            this.TableStructView.Name = "TableStructView";
            this.TableStructView.Size = new System.Drawing.Size(479, 537);
            this.TableStructView.TabIndex = 1;
            this.TableStructView.UseCompatibleStateImageBehavior = false;
            this.TableStructView.View = System.Windows.Forms.View.Details;
            this.TableStructView.SelectedIndexChanged += new System.EventHandler(this.TableStructView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "字段名字";
            this.columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "字段类型";
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "字段长度";
            this.columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "是否允许为空";
            this.columnHeader4.Width = 130;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "小数位的长度";
            this.columnHeader6.Width = 150;
            // 
            // TableDataView
            // 
            this.TableDataView.GridLines = true;
            this.TableDataView.HideSelection = false;
            this.TableDataView.HoverSelection = true;
            this.TableDataView.Location = new System.Drawing.Point(681, 12);
            this.TableDataView.Name = "TableDataView";
            this.TableDataView.Size = new System.Drawing.Size(694, 537);
            this.TableDataView.TabIndex = 2;
            this.TableDataView.UseCompatibleStateImageBehavior = false;
            this.TableDataView.View = System.Windows.Forms.View.Details;
            // 
            // ChangeDatabaseBut
            // 
            this.ChangeDatabaseBut.Location = new System.Drawing.Point(11, 562);
            this.ChangeDatabaseBut.Name = "ChangeDatabaseBut";
            this.ChangeDatabaseBut.Size = new System.Drawing.Size(257, 39);
            this.ChangeDatabaseBut.TabIndex = 3;
            this.ChangeDatabaseBut.Text = "切换成SqlServer数据库";
            this.ChangeDatabaseBut.UseVisualStyleBackColor = true;
            this.ChangeDatabaseBut.Click += new System.EventHandler(this.ChangeDatabaseBut_Click);
            // 
            // ImportDatabaseBut
            // 
            this.ImportDatabaseBut.Location = new System.Drawing.Point(547, 562);
            this.ImportDatabaseBut.Name = "ImportDatabaseBut";
            this.ImportDatabaseBut.Size = new System.Drawing.Size(227, 39);
            this.ImportDatabaseBut.TabIndex = 4;
            this.ImportDatabaseBut.Text = "导入数据到SqlServer";
            this.ImportDatabaseBut.UseVisualStyleBackColor = true;
            this.ImportDatabaseBut.Click += new System.EventHandler(this.ImportDatabaseBut_Click);
            // 
            // BackUpButBak
            // 
            this.BackUpButBak.Location = new System.Drawing.Point(767, 562);
            this.BackUpButBak.Name = "BackUpButBak";
            this.BackUpButBak.Size = new System.Drawing.Size(201, 39);
            this.BackUpButBak.TabIndex = 5;
            this.BackUpButBak.Text = "备份成为bak文件";
            this.BackUpButBak.UseVisualStyleBackColor = true;
            this.BackUpButBak.Click += new System.EventHandler(this.BackUpBut_Click);
            // 
            // ExitBut
            // 
            this.ExitBut.Location = new System.Drawing.Point(1131, 562);
            this.ExitBut.Name = "ExitBut";
            this.ExitBut.Size = new System.Drawing.Size(114, 39);
            this.ExitBut.TabIndex = 6;
            this.ExitBut.Text = "退出系统";
            this.ExitBut.UseVisualStyleBackColor = true;
            this.ExitBut.Click += new System.EventHandler(this.ExitBut_Click);
            // 
            // CreateTableToBut
            // 
            this.CreateTableToBut.Location = new System.Drawing.Point(265, 562);
            this.CreateTableToBut.Name = "CreateTableToBut";
            this.CreateTableToBut.Size = new System.Drawing.Size(285, 39);
            this.CreateTableToBut.TabIndex = 9;
            this.CreateTableToBut.Text = "创建对应数据库到SqlServer";
            this.CreateTableToBut.UseVisualStyleBackColor = true;
            this.CreateTableToBut.Click += new System.EventHandler(this.button3_Click);
            // 
            // BackUpButDmp
            // 
            this.BackUpButDmp.Location = new System.Drawing.Point(960, 562);
            this.BackUpButDmp.Name = "BackUpButDmp";
            this.BackUpButDmp.Size = new System.Drawing.Size(179, 39);
            this.BackUpButDmp.TabIndex = 10;
            this.BackUpButDmp.Text = "Oracle备份dmp";
            this.BackUpButDmp.UseVisualStyleBackColor = true;
            this.BackUpButDmp.Click += new System.EventHandler(this.BackUpButDmp_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1416, 606);
            this.Controls.Add(this.BackUpButDmp);
            this.Controls.Add(this.CreateTableToBut);
            this.Controls.Add(this.ExitBut);
            this.Controls.Add(this.BackUpButBak);
            this.Controls.Add(this.ImportDatabaseBut);
            this.Controls.Add(this.ChangeDatabaseBut);
            this.Controls.Add(this.TableDataView);
            this.Controls.Add(this.TableStructView);
            this.Controls.Add(this.DatabaseListView);
            this.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Location = new System.Drawing.Point(300, 0);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainPage";
            this.Text = "数据库登录系统界面";
            this.Load += new System.EventHandler(this.OracleMainPage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView DatabaseListView;
        private System.Windows.Forms.ListView TableStructView;
        private System.Windows.Forms.ListView TableDataView;
        private System.Windows.Forms.Button ChangeDatabaseBut;
        private System.Windows.Forms.Button ImportDatabaseBut;
        private System.Windows.Forms.Button BackUpButBak;
        private System.Windows.Forms.Button ExitBut;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button CreateTableToBut;
        private System.Windows.Forms.Button BackUpButDmp;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}

