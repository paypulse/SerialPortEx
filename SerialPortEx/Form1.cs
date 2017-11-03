using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;


namespace SerialPortEx
{
    public partial class SerialComm_Load : Form
    {
        public SerialComm_Load()
        {
            InitializeComponent();
        }

        //serial port를 관리할 객체를 생성 property
        private SerialPort _Port;
        private SerialPort Port
        {
            get
            {
                if(_Port == null)
                {
                    _Port = new SerialPort();
                    _Port.PortName = "COM1";
                    _Port.BaudRate = 9600;
                    _Port.DataBits = 8;
                    _Port.Parity = Parity.None;
                    _Port.Handshake = Handshake.None;
                    _Port.StopBits = StopBits.One;
                    _Port.Encoding = Encoding.UTF8;
                    _Port.DataReceived += Port_DataReceived;

                }
                return _Port;
            }
        }

        //시리얼 포트를 통해 데이터가 수신되면 발생하는 이벤트 
        private void Port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //현재 수신된 데이터를 버퍼에서 몽땅 가져 온다
            String msg = Port.ReadExisting();

            //대리자를 통해 현재 폼의 상태를 변경 시킬때 주로 쓴다
            // 왜 바로 컨트롤의 상태를 바꿔주면 안되냐 하면 다른 
            //쓰레드 끼리는 서로의 데이터 안전성을 위해 바로 접근 할 수 없다.
            //즉, 수신 쓰레드에서 폼의 상태를 변경하라고 대리자를 통해 시켜두면, 메인 쓰레드 차례가
            //돌아 왔을때 이일을 처리하게 되는 것이다. 
            this.Invoke(new EventHandler(delegate
            {
                Strings = String.Format("[RECV] {0}", msg);
            }));

        }


        //상태 표시를 위한 속성 Property : 시리얼 포트 상태및 컨트롤 제어
        private Boolean IsOpen
        {
            get { return Port.IsOpen; }
            set
            {
                if(value)
                {
                    Strings = "연결 됨";
                    btConnectControl.Text = "연결 끊기";
                    tbRecvMessage.Enabled = true;
                    tbSendMessage.Enabled = true;
                    btSendMessage.Enabled = true;
                    gbSettings.Enabled = false;
                }
                else
                {
                    Strings = "연결 해제 됨";
                    btConnectControl.Text = "연결";
                    tbRecvMessage.Enabled = false;
                    tbSendMessage.Enabled = false;
                    btSendMessage.Enabled = false;
                    gbSettings.Enabled = true;
                }
            }
        }

        /*로그 제어*/
        private StringBuilder _Strings;
        private String Strings
        {
            set
            {
                if(_Strings == null)
                {
                    _Strings = new StringBuilder(1024);
                }

                //로그 길이가 1024자가 되면, 이전 로그 삭제
                if (_Strings.Length >= (1024 - value.Length))
                {
                    _Strings.Clear();
                }

                //로그 추가 및 화면 표시
                _Strings.AppendLine(value);
                tbRecvMessage.Text = _Strings.ToString();
            }
        }

        private void SerialComm_Load_Load(object sender, EventArgs e)
        {
            //시리얼 포트 목록 갱신 --> 열려 있는 Comport를 가져 와라
            cbComPort.DataSource = SerialPort.GetPortNames();

            //기타 셋팅 목록 기본값 선택
            cbBaudRate.SelectedItem = 0;
            cbDataSize.SelectedItem = 0;
            cbParity.SelectedItem = 0;
            cbHandShake.SelectedItem = 0;


        }

        private void btConnectControl_Click(object sender, EventArgs e)
        {
            if(!Port.IsOpen)
            {
                // 현재 시리얼이 연결된 상태가 아니면 연결
                Port.PortName = cbComPort.SelectedItem.ToString();
                Port.BaudRate = Convert.ToInt32(cbBaudRate.SelectedItem);
                Port.DataBits = Convert.ToInt32(cbDataSize.SelectedItem);
                Port.Parity = (Parity)cbParity.SelectedIndex;
                Port.Handshake = (Handshake)cbHandShake.SelectedItem;

                try
                {
                    //연결
                    Port.Open();
                }catch (Exception ex) { Strings = String.Format("[ERR] {0}", ex.Message); }
            }
            else
            {
                // 현재 시리얼이 연결 상태이면, 연결 해제
                Port.Close();
            }

            // 상태 변경
            IsOpen = Port.IsOpen;
        }

        private void btSendMessage_Click(object sender, EventArgs e)
        {
            //보낼 메세지가 없으면 종료 
            String text = tbSendMessage.Text.Trim();
            if (String.IsNullOrEmpty(text)) return;

            try
            {
                //메세지 전송
                Port.WriteLine(text);
                //표시
                Strings = String.Format("[SEND] {0}", text);
            }catch(Exception ex)
            {
                Strings = string.Format("[ERR] {0}", ex.Message);
            }
        }
    }
}
