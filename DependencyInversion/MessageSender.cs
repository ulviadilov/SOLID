using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{
    internal class MessageSender
    {
        List<IMessageSender> _senderList = new List<IMessageSender>();

        public MessageSender(List<IMessageSender> senderList)
        {
            this._senderList = senderList;
        }

        public void Send()
        {
            foreach (var item in _senderList)
            {
                item.Send();
            }
        }
    }
}
