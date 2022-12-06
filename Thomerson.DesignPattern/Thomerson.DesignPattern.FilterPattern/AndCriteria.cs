using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace 过滤器模式
{
    class AndCriteria : Criteria
    {
        private Criteria criteria;
        private Criteria otherCriteria;

        public AndCriteria(Criteria criteria, Criteria otherCriteria)
        {
            this.criteria = criteria;
            this.otherCriteria = otherCriteria;
        }

        public List<Person> MeetCriteria(List<Person> persons)
        {
            var first = criteria.MeetCriteria(persons);
            var result = otherCriteria.MeetCriteria(first);
            return result;
        }
    }

}
