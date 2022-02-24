
namespace BackpacForm
{
    partial class Table
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
            this.TableListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // TableListView
            // 
            this.TableListView.HideSelection = false;
            this.TableListView.Location = new System.Drawing.Point(13, 13);
            this.TableListView.Name = "TableListView";
            this.TableListView.Size = new System.Drawing.Size(503, 401);
            this.TableListView.TabIndex = 0;
            this.TableListView.UseCompatibleStateImageBehavior = false;
            this.TableListView.View = System.Windows.Forms.View.Details;
            // 
            // Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 426);
            this.Controls.Add(this.TableListView);
            this.Name = "Table";
            this.Text = "Таблица промежуточных данных";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView TableListView;
    }
}