using BixHubWrapper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ExampleSIGN
{
    public partial class FormSign : Form
    {
        BixHubWrapper.SignCaller _signCaller;

        public FormSign()
        {
            InitializeComponent();

            if (System.IO.File.Exists(@"c:\temp\BixHub\BixSign.txt"))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(SettaggioIniziale));
                using (TextReader reader = new StringReader(System.IO.File.ReadAllText(@"c:\temp\BixHub\BixSign.txt")))
                {
                    var settaggioIniziale = (SettaggioIniziale)new XmlSerializer(typeof(SettaggioIniziale)).Deserialize(reader);
                    _txtAuthUrl.Text = settaggioIniziale.AuthUrl;
                    _txtSignUrl.Text = settaggioIniziale.SignUrl;
                    _txtIdeUrl.Text = settaggioIniziale.IdeUrl;
                    _txtClientGuid.Text = settaggioIniziale.ClientGuid;
                    _txtClientId.Text = settaggioIniziale.ClientId;
                    _txtClientSecret.Text = settaggioIniziale.ClientSecret;
                    _txtMail.Text = settaggioIniziale.Mail;
                    _txtDescription.Text = settaggioIniziale.Description;
                    _txtTaxCode.Text = settaggioIniziale.TaxCode;
                    _txtPhoneNumber.Text = settaggioIniziale.PhoneNumber;
                    _txtReturnUrl.Text = settaggioIniziale.ReturnUrl;
                    _txtExternalID.Text = settaggioIniziale.ExternalID;
                }
            }
        }

        private void _btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                _signCaller = new BixHubWrapper.SignCaller(_txtAuthUrl.Text, _txtSignUrl.Text);
                _signCaller.Login(_txtClientGuid.Text, _txtClientId.Text, _txtClientSecret.Text);
                AddLogInfo("Login avvenuta con successo: " + _signCaller.AccessToken);
            }
            catch (Exception ex)
            {
                AddLogError(ex.Message);
            }
        }

        private void _btnCreaSessioneFES_Click(object sender, EventArgs e)
        {
            try
            {
                if (_signCaller == null)
                    throw new Exception("Fare login");

                Guid sessionId = _signCaller.CreateNewSignSessionFES(_txtMail.Text, _txtDescription.Text, _txtTaxCode.Text, _txtPhoneNumber.Text, _txtReturnUrl.Text, _txtExternalID.Text, _cbAddApprover.Checked);
                AddLogInfo("Sessione creata con successo: " + sessionId);
            }
            catch (Exception ex)
            {
                AddLogError(ex.Message);
            }
        }

        private void _btnSaveSettings_Click(object sender, EventArgs e)
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(SettaggioIniziale));
                TextWriter textWriter = new StreamWriter(@"c:\temp\BixHub\BixSign.txt");

                var settaggioIniziale = new SettaggioIniziale
                {
                    AuthUrl = _txtAuthUrl.Text,
                    SignUrl = _txtSignUrl.Text,
                    IdeUrl = _txtIdeUrl.Text,
                    ClientGuid = _txtClientGuid.Text,
                    ClientId = _txtClientId.Text,
                    ClientSecret = _txtClientSecret.Text,
                    Mail = _txtMail.Text,
                    Description = _txtDescription.Text,
                    TaxCode = _txtTaxCode.Text,
                    PhoneNumber = _txtPhoneNumber.Text,
                    ReturnUrl = _txtReturnUrl.Text,
                    ExternalID = _txtExternalID.Text,
                };
                xmlSerializer.Serialize(textWriter, settaggioIniziale);
                textWriter.Close();

                AddLogInfo("Salvataggio concluso con successo.");
            }
            catch (Exception ex)
            {
                AddLogError(ex.Message);
            }
        }

        private void AddLog(string log)
        {
            _txtLog.Text += Environment.NewLine + log;
        }

        private void AddLogError(string log)
        {
            log = "ERROR: " + log;
            AddLog(log);
        }

        private void AddLogInfo(string log)
        {
            log = "INFO: " + log;
            AddLog(log);
        }

        private void _btnGetSessionStatus_Click(object sender, EventArgs e)
        {
            try
            {
                if (_signCaller == null)
                    throw new Exception("Fare login");

                var sessions = _signCaller.GetSessionList();
                for (int i = 0; i < sessions.Count; i++)
                {

                    AddLogInfo(string.Format("Sessione {0}:", i));
                    AddLogInfo(sessions[i].ToString());
                }

                LoadData(sessions);

                AddLogInfo("GetSessionList eseguita con successo: ");
            }
            catch (Exception ex)
            {
                AddLogError(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (_signCaller == null)
                    throw new Exception("Fare login");

                if (string.IsNullOrWhiteSpace(_txtSessionID.Text))
                    throw new Exception("SessionId mancante");

                var sessionId = Guid.Parse(_txtSessionID.Text);
                var session = _signCaller.GetSession(sessionId);
                AddLogInfo(session.ToString());

                AddLogInfo("GetSession eseguita con successo: ");
            }
            catch (Exception ex)
            {
                AddLogError(ex.ToString());
            }
        }

        private void LoadData(List<BixHubWrapper.Model.InfoSessionResponse> sessions)
        {
            sessionData.DataSource = null;
            sessionData.Columns.Clear();
            sessionData.DataSource = sessions;
            sessionData.Columns.Add(new DataGridViewButtonColumn() { Text = "Apri sessione", UseColumnTextForButtonValue = true });
        }

        private void sessionData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                var value = senderGrid.Rows[e.RowIndex].Cells["SessionGuid"].Value.ToString();
                var nextUri = senderGrid.Rows[e.RowIndex].Cells["NextUri"].Value.ToString();
                var url = nextUri; //DEMO
                System.Diagnostics.Process.Start(url);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (_signCaller == null)
                    throw new Exception("Fare login");

                if (string.IsNullOrWhiteSpace(_txtSessionID.Text))
                    throw new Exception("SessionId mancante");

                var sessionId = Guid.Parse(_txtSessionID.Text);
                _signCaller.DeleteIdentificationSession(sessionId);
                AddLogInfo("Sessione cancellata con successo");
            }
            catch (Exception ex)
            {
                AddLogError(ex.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (_signCaller == null)
                    throw new Exception("Fare login");

                if (string.IsNullOrWhiteSpace(_txtSessionID.Text))
                    throw new Exception("SessionId mancante");

                var sessionId = Guid.Parse(_txtSessionID.Text);


                var session = _signCaller.GetSession(sessionId);
                if (session.Status != "Completed")
                {
                    AddLogInfo("Sessione di firma non ancora completata");
                    return;
                }

                using (var folderBrowserDialog1 = new FolderBrowserDialog())
                {
                    DialogResult result = folderBrowserDialog1.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        string folderName = folderBrowserDialog1.SelectedPath;
                        string fullname = Directory.CreateDirectory(Path.Combine(folderName, sessionId.ToString())).FullName;

                        var files = _signCaller.GetSignedFiles(sessionId);
                        foreach (var file in files)
                            File.WriteAllBytes(Path.Combine(fullname, file.Key + ".PDF"), file.Value);

                        var auditLogSign = _signCaller.GetAuditTrailSignBySessionGuid(sessionId);
                        File.WriteAllBytes(Path.Combine(fullname, "auditLogSign.pdf"), auditLogSign);

                        IdeCaller ideCaller = new IdeCaller(_txtAuthUrl.Text, _txtIdeUrl.Text, _signCaller.AccessToken);
                        var signers = _signCaller.GetSignersAndIdeSession(sessionId);
                        foreach (var signer in signers)
                        {
                            var acquiredIDInfoResponse = ideCaller.GetIdentificationEvidenceBySessionGuid(signer.Key);
                            // Se AI
                            if (acquiredIDInfoResponse.IDCard.FrontFileData != null)
                            {
                                File.WriteAllBytes(Path.Combine(fullname, signer.Value + "_IDCard_Front.jpeg"), acquiredIDInfoResponse.IDCard.FrontFileData);
                            }
                            if (acquiredIDInfoResponse.IDCard.RearFileData != null)
                            {
                                File.WriteAllBytes(Path.Combine(fullname, signer.Value + "_IDCard_Rear.jpeg"), acquiredIDInfoResponse.IDCard.RearFileData);
                            }
                            if (acquiredIDInfoResponse.Selfie.FileData != null)
                            {
                                File.WriteAllBytes(Path.Combine(fullname, signer.Value + "_Selfie.jpeg"), acquiredIDInfoResponse.Selfie.FileData);
                            }
                            if (acquiredIDInfoResponse.LivenessDetection.FileData != null)
                            {
                                File.WriteAllBytes(Path.Combine(fullname, signer.Value + "_Liveness.mp4"), acquiredIDInfoResponse.LivenessDetection.FileData);
                            }

                            // Se SPID/CIE
                            if (acquiredIDInfoResponse.DigitalIdentity != null)
                            {
                                File.WriteAllText(Path.Combine(fullname, signer.Value + "_Request.xml"), acquiredIDInfoResponse.DigitalIdentity.Request);
                            }
                            if (acquiredIDInfoResponse.DigitalIdentity != null)
                            {
                                File.WriteAllText(Path.Combine(fullname, signer.Value + "_Response.xml"), acquiredIDInfoResponse.DigitalIdentity.Response);
                            }

                            var auditLog = ideCaller.GetAuditLogBySessionGuid(signer.Key);
                            File.WriteAllBytes(Path.Combine(fullname, signer.Value + "_auditLog.pdf"), auditLog);
                        }

                        AddLogInfo("Download evidenze identificazione eseguito sul path: " + fullname);
                        System.Diagnostics.Process.Start("explorer.exe", fullname);
                    }
                }
            }
            catch (Exception ex)
            {
                AddLogError(ex.ToString());
            }
        }

        private void _btnCreaSessioneFEA_Click(object sender, EventArgs e)
        {
            try
            {
                if (_signCaller == null)
                    throw new Exception("Fare login");

                Guid sessionId = _signCaller.CreateNewSignSessionFEA(_txtMail.Text, _txtDescription.Text, _txtTaxCode.Text, _txtPhoneNumber.Text, _txtReturnUrl.Text, _txtExternalID.Text, _cbAddApprover.Checked);
                AddLogInfo("Sessione creata con successo: " + sessionId);
            }
            catch (Exception ex)
            {
                AddLogError(ex.Message);
            }
        }
    }

    [Serializable()]
    public class SettaggioIniziale
    {
        public string AuthUrl { get; set; }
        public string SignUrl { get; set; }
        public string IdeUrl { get; set; }
        public string ClientGuid { get; set; }
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }


        public string Mail { get; set; }
        public string Description { get; set; }
        public string TaxCode { get; set; }
        public string PhoneNumber { get; set; }
        public string ReturnUrl { get; set; }
        public string ExternalID { get; set; }
    }
}