using AutoMapper;
using EmployeeCrm.Application.DTOs.EmployeeDTOs;
using EmployeeCrm.Application.DTOs.EventDTOs;
using EmployeeCrm.Application.DTOs.ExpenseDTOs;
using EmployeeCrm.Application.DTOs.ExpenseTypeDTOs;
using EmployeeCrm.Application.DTOs.GroupDTOs;
using EmployeeCrm.Application.DTOs.İnformationListDTOs;
using EmployeeCrm.Application.DTOs.İnternshipDTOs;
using EmployeeCrm.Application.DTOs.LessonDTOs;
using EmployeeCrm.Application.DTOs.MeetingDTOs;
using EmployeeCrm.Application.DTOs.MessageDTOs;
using EmployeeCrm.Application.DTOs.PositionDTOs;
using EmployeeCrm.Application.DTOs.RegisterBlankDTOs;
using EmployeeCrm.Application.DTOs.RoleDTOs;
using EmployeeCrm.Application.DTOs.SatisfactionsDTOs;
using EmployeeCrm.Application.DTOs.StudentDTOs;
using EmployeeCrm.Application.DTOs.StudentPaymentDTOs;
using EmployeeCrm.Application.DTOs.TaskDTOs;
using EmployeeCrm.Application.DTOs.UserAttendanceDTOs;
using EmployeeCrm.Application.DTOs.UserDTOs;
using EmployeeCrm.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Application.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Event, CreateEventDTO>().ReverseMap();
            CreateMap<Event, EventListDTO>().ReverseMap();
            CreateMap<Event, EventUpdateDTO>().ReverseMap();

            CreateMap<Employee, EmployeeCreateDTO>().ReverseMap();
            CreateMap<Employee, EmployeeDTO>().ReverseMap();
            CreateMap<Employee, EmployeeUpdateDTO>().ReverseMap();

            CreateMap<Expense, ExpenseCreateDTO>().ReverseMap();
            CreateMap<Expense, ExpenseDTO>().ReverseMap();
            CreateMap<Expense, ExpenseUpdateDTO>().ReverseMap();

            CreateMap<ExpenseType, ExpenseTypeCreateDTO>().ReverseMap();
            CreateMap<ExpenseType, ExpenseTypeDTO>().ReverseMap();
            CreateMap<ExpenseType, ExpenseTypeUpdateDTO>().ReverseMap();

            CreateMap<Group, GroupCreateDTO>().ReverseMap();
            CreateMap<Group, GroupDTO>().ReverseMap();
            CreateMap<Group, GroupUpdateDTO>().ReverseMap();

            CreateMap<InformationList, InformationListCreateDTO>().ReverseMap();
            CreateMap<InformationList, InformationListDTO>().ReverseMap();
            CreateMap<InformationList, InformationListUpdateDTO>().ReverseMap();

            CreateMap<Internship, InternshipCreateDTO>().ReverseMap();
            CreateMap<Internship, InternshipDTO>().ReverseMap();
            CreateMap<Internship, InternshipUpdateDTO>().ReverseMap();

            CreateMap<Lesson, LessonCreateDTO>().ReverseMap();
            CreateMap<Lesson, LessonDTO>().ReverseMap();
            CreateMap<Lesson, LessonUpdateDTO>().ReverseMap();

            CreateMap<Meeting, MeetingCreateDTO>().ReverseMap();
            CreateMap<Meeting, MeetingDTO>().ReverseMap();
            CreateMap<Meeting, MeetingUpdateDTO>().ReverseMap();

            CreateMap<Message, MessageCreateDTO>().ReverseMap();
            CreateMap<Message, MessageDTO>().ReverseMap();
            CreateMap<Message, MessageUpdateDTO>().ReverseMap();

            CreateMap<Position, PositionCreateDTO>().ReverseMap();
            CreateMap<Position, PositionDTO>().ReverseMap();
            CreateMap<Position, PositionUpdateDTO>().ReverseMap();

            CreateMap<RegisterBlank, RegisterBlankCreateDTO>().ReverseMap();
            CreateMap<RegisterBlank, RegisterBlankDTO>().ReverseMap();
            CreateMap<RegisterBlank, RegisterBlankUpdateDTO>().ReverseMap();

            CreateMap<Role, RoleCreateDTO>().ReverseMap();
            CreateMap<Role, RoleDTO>().ReverseMap();
            CreateMap<Role, RoleUpdateDTO>().ReverseMap();

            CreateMap<Satisfaction, SatisfactionCreateDTO>().ReverseMap();
            CreateMap<Satisfaction, SatisfactionDTO>().ReverseMap();
            CreateMap<Satisfaction, SatisfactionUpdateDTO>().ReverseMap();

            CreateMap<Student, StudentCreateDTO>().ReverseMap();
            CreateMap<Student, StudentDTO>().ReverseMap();
            CreateMap<Student, StudentUpdateDTO>().ReverseMap();

            CreateMap<StudentPayment, StudentPaymentCreateDTO>().ReverseMap();
            CreateMap<StudentPayment, StudentPaymentDTO>().ReverseMap();
            CreateMap<StudentPayment, UserAttendanceUpdateDTO>().ReverseMap();

            CreateMap<EmployeeCrm.Domain.Entities.Task, TaskCreateDTO>().ReverseMap();
            CreateMap<EmployeeCrm.Domain.Entities.Task, TaskDTO>().ReverseMap();
            CreateMap<EmployeeCrm.Domain.Entities.Task, TaskUpdateDTO>().ReverseMap();

            CreateMap<UserAttendance, UserAttendanceCreateDTO>().ReverseMap();
            CreateMap<UserAttendance, UserAttendanceDTO>().ReverseMap();
            CreateMap<UserAttendance, UserAttendanceUpdateDTO>().ReverseMap();

            CreateMap<User, UserCreateDTO>().ReverseMap();
            CreateMap<User, UserDTO>().ReverseMap();
            CreateMap<User, UserUpdateDTO>().ReverseMap();
        }
    }
}
