using GraphQL.Types;
using GraphQlDotNet.Model;

namespace GraphQlDotNet.Types
{
    public class ReservationType : ObjectGraphType<Reservation>
    {
        public ReservationType()
        {
            Field(m => m.Id);
            Field(m => m.Name);
            Field(m => m.Date);
            Field(m => m.Email);
            Field(m => m.Phone);
            Field(m => m.TotalPeople);
            Field(m => m.Time);
            
            
        }
    }
}