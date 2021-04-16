using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TableBusConsole.Models
{
    public class RecordFlight
    {
        public int Id { get; set; }
        public int TableId { get; set; }
        public int UserId { get; set; }
        
        public virtual Table Table { get; set; }
        public virtual User User { get; set; }

        public RecordFlight(int TableId, int UserId)
        {
            this.TableId = TableId;
            this.UserId = UserId;

            this.Table = DataContext.Tables.Find(x => x.Id == TableId);
            this.User = DataContext.Users.Find(x => x.Id == UserId);
        }

        // Конструктор без параметров
        public RecordFlight()
        {

        }

        public override string ToString()
        {
            return $"ID: {Id} | TableId: {TableId} | UserId: {UserId}";
        }
    }
}
