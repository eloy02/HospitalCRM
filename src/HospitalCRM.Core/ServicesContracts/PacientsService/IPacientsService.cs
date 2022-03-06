using HospitalCRM.Core.Model;
using HospitalCRM.Core.ServicesContracts.PacientsService.Commands;
using HospitalCRM.Core.ServicesContracts.PacientsService.Queries;
using ProtoBuf.Grpc.Configuration;

namespace HospitalCRM.Core.ServicesContracts.PacientsService;

[Service]
public interface IPacientsService
{
    [Operation]
    ValueTask<Response> AddPacient(Request<AddPacientCommand> addRequest);

    [Operation]
    ValueTask<Response> UpdatePacient(Request<UpdatePacientDataCommand> updateRequest);

    [Operation]
    ValueTask<Response<IEnumerable<Pacient>>> GetPatients(Request<GetPacientsQuery> pacientSearch);

    [Operation]
    ValueTask<Response> AddPacientVisit(Request<CreatePacientVisitCommand> visitRequest);

    [Operation]
    ValueTask<Response<IEnumerable<PacientVisit>>> GetPacientVisit(Request<GetPacientsVisitsQuery> visitsRequest);
}