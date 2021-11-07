using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2Test
{
    public class CardMapping : ClassMap<Card>
    {
       
        public CardMapping()
        {
            Table("Card");
        }
    }
}
