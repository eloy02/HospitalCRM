using HospitalCRM.Core.Model;
using HospitalCRM.Core.Model.Requests;
using ProtoBuf.Grpc.Configuration;

namespace HospitalCRM.Core.ServicesContracts;

[Service]
public interface IPacientsService
{
    [Operation]
    ValueTask<Response> AddPacient(Request<Pacient> addRequest);

    [Operation]
    ValueTask<Response> UpdatePacient(Request<Pacient> updateRequest);

    [Operation]
    ValueTask<Response<IEnumerable<Doctor>>> GetDoctors(Request<string> doctorSearch);

    [Operation]
    ValueTask<Response<IEnumerable<Pacient>>> GetPatients(Request<string> pacientSearch);

    [Operation]
    ValueTask<Response> AddPacientVisit(Request<PacientVisit> visitRequest);

    [Operation]
    ValueTask<Response<IEnumerable<PacientVisit>>> GetPacientVisit(Request<PacientVisitRequest> visitsRequest);
}