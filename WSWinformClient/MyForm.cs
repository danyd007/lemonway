using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSWinformClient
{
    public partial class MyForm : Form
    {
        MyWebService.MyWebService myWS;
        WaitForm waitForm;

        public MyForm()
        {
            InitializeComponent();
        }

        private void MyForm_Load(object sender, EventArgs e)
        {
            myWS = new MyWebService.MyWebService();
        }

        private void ShowForm()
        {
            waitForm = new WaitForm();
            waitForm.StartPosition = FormStartPosition.CenterParent;
            waitForm.ShowDialog();

        }

        private async void btn_compute_Click(object sender, EventArgs e)
        {
            int n = 0;
            Logger.Log("Call Web Service " + System.Reflection.MethodBase.GetCurrentMethod().Name + ".", LogType.Info);

            try
            {
                if (int.TryParse(txtNumber.Text, out n))
                {
                    BeginInvoke((Action)(() => ShowForm()));
                    double res = await Task.Run(() => myWS.Fibonacci(n))
                        .ContinueWith((t) =>
                        {
                            if (t.IsFaulted)
                                throw t.Exception;
                            else
                                return t.Result;
                        });

                    waitForm.Close();

                    MessageBox.Show(res.ToString());
                }
                else
                    MessageBox.Show("Invalid number : must be an integer.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception exc)
            {
                Logger.Log("Error calling method " + System.Reflection.MethodBase.GetCurrentMethod().Name + ". Exception : " + exc.Message, LogType.Error);
                waitForm.Close();
                MessageBox.Show("Error : " + exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private async void btnConvert_Click(object sender, EventArgs e)
        {
            Logger.Log("Call Web Service " + System.Reflection.MethodBase.GetCurrentMethod().Name + ".", LogType.Info);

            try
            {
                BeginInvoke((Action)(() => ShowForm()));

                string res = await Task.Run(() => myWS.XmlToJson(txtXML.Text, true))
                    .ContinueWith((t) =>
                    {
                        if (t.IsFaulted)
                            throw t.Exception;
                        else
                            return t.Result;
                    });

                waitForm.Close();

                MessageBox.Show(res.ToString());
            }
            catch (Exception exc)
            {
                Logger.Log("Error calling method " + System.Reflection.MethodBase.GetCurrentMethod().Name + ". Exception : " + exc.Message, LogType.Error);
                waitForm.Close();
                MessageBox.Show("Error : " + exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }





    }
}
