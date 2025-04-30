        private void button1_Click(object sender, EventArgs e)
        {

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                BackColor = colorDialog1.Color;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                button1.Font = fontDialog1.Font;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
           if( MessageBox.Show("هل تريد الاغلاق حقاً", "close", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }