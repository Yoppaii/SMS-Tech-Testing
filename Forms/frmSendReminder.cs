using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace SMS_Tech_testing1
{
    public partial class frmSendReminder : Form
    {
        public frmSendReminder()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                string accountSid = "AC1b026144618e4697043c32927fc0e014";
                string authToken = "108e6ef013344bfae4847f4468098a7c";
                string twilioPhoneNumber = "+12315257470";

                string senderNumber = txtSenderNumber.Text;
                string receiverNumber = txtReceiverNumber.Text;
                string messageBody = txtMessage.Text;

                TwilioClient.Init(accountSid, authToken);

                var message = MessageResource.Create(
                    body: messageBody,
                    from: new Twilio.Types.PhoneNumber(twilioPhoneNumber),
                    to: new Twilio.Types.PhoneNumber(receiverNumber)
                );

                MessageBox.Show($"Message sent successfully!\nSID: {message.Sid}");
            }
            catch (Twilio.Exceptions.ApiException ex)
            {
                MessageBox.Show($"Twilio API error: {ex.Message}\nError code: {ex.Code}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            }
            private void frmSendReminder_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
