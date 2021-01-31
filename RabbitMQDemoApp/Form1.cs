using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RabbitMQDemoApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        RabbitMQProducer producer = new RabbitMQProducer();
        RabbitMQConsumer consumer = new RabbitMQConsumer();
        private void Form1_Load(object sender, EventArgs e)
        {
            
            Task.Run(()=>consumer.StartConsumer("hello"));
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            producer.Send(txtMessage.Text, "hello");
        }
    }
}
