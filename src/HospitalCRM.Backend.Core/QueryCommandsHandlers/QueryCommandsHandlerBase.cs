using HospitalCRM.Backend.Core.Database;

namespace HospitalCRM.Backend.Core.QueryCommandsHandlers;

public class QueryCommandsHandlerBase
{
    protected DataContext _context;

    public QueryCommandsHandlerBase(DataContext context)
    {
        _context = context;
    }
}