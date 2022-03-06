using HospitalCRM.Core.Model;
using HospitalCRM.Core.ServicesContracts.DoctorsService.Queries;
using ProtoBuf.Grpc.Configuration;

namespace HospitalCRM.Core.ServicesContracts.DoctorsService;

[Service]
public interface IDoctorsService
{
    [Operation]
    ValueTask<Response<IEnumerable<Doctor>>> GetDoctors(Request<GetDoctorsQuery> doctorSearch);
}