using System;
using System.Collections.Generic;

namespace DevLair.ORM.Model.Entities
{
    public class PrivateMessage
    {
        public virtual int Id { get; private set; } //внутренний идентификатор-генератор
        public virtual string TopicMessage { get; set; } //тема сообщения
        public virtual string BodyMessage { get; set; } //тело сообщения
        public virtual byte[] Attachment { get; set; } //вложение
        public virtual string NameFromSubject { get; set; } //от кого
        public virtual DateTime TimeReceive { get; set; } //дата и время отправки 
        public virtual string NameToSubject { get; set; } //кому
        public virtual int IdFromSubject { get; set; }
        public virtual int IdToSubject { get; set; }
    }
}
