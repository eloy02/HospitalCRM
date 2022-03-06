using HospitalCRM.Core.Model;
using MediatR;
using ProtoBuf;

namespace HospitalCRM.Core.ServicesContracts.DoctorsService.Queries;

[ProtoContract]
public class GetDoctorsQuery : IRequest<IEnumerable<Doctor>>
{
}