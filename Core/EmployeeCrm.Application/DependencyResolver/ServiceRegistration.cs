using AutoMapper;
using EmployeeCrm.Application.AutoMapper;
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
using EmployeeCrm.Application.Validations.Employee;
using EmployeeCrm.Application.Validations.Event;
using EmployeeCrm.Application.Validations.Expense;
using EmployeeCrm.Application.Validations.ExpenseType;
using EmployeeCrm.Application.Validations.Group;
using EmployeeCrm.Application.Validations.InformationList;
using EmployeeCrm.Application.Validations.Internship;
using EmployeeCrm.Application.Validations.Lesson;
using EmployeeCrm.Application.Validations.Meeting;
using EmployeeCrm.Application.Validations.Message;
using EmployeeCrm.Application.Validations.Position;
using EmployeeCrm.Application.Validations.RegisterBlank;
using EmployeeCrm.Application.Validations.Role;
using EmployeeCrm.Application.Validations.Satisfaction;
using EmployeeCrm.Application.Validations.Student;
using EmployeeCrm.Application.Validations.StudentPayment;
using EmployeeCrm.Application.Validations.Task;
using EmployeeCrm.Application.Validations.User;
using EmployeeCrm.Application.Validations.UserAttendance;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace EmployeeCrm.Application.DependencyResolver
{
    public static class ServiceRegistration
    {
        public static void AddApplicationServices(this IServiceCollection services)
        {

            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });

            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);



            services.AddScoped<IValidator<EmployeeCreateDTO>, EmployeeCreateValidation>();
            services.AddScoped<IValidator<EmployeeUpdateDTO>, EmployeeUpdateValidation>();

            services.AddScoped<IValidator<CreateEventDTO>, EventCreateValidation>();
            services.AddScoped<IValidator<EventUpdateDTO>, EventUpdateValidation>();

            services.AddScoped<IValidator<ExpenseCreateDTO>, ExpenseCreateValidation>();
            services.AddScoped<IValidator<ExpenseUpdateDTO>, ExpenseUpdateValidation>();

            services.AddScoped<IValidator<ExpenseTypeCreateDTO>, ExpenseTypeCreateValidation>();
            services.AddScoped<IValidator<ExpenseTypeUpdateDTO>, ExpenseTypeUpdateValidation>();

            services.AddScoped<IValidator<GroupCreateDTO>, GroupCreateValidation>();
            services.AddScoped<IValidator<GroupUpdateDTO>, GroupUpdateValidation>();

            services.AddScoped<IValidator<InformationListCreateDTO>, InformationListCreateValidation>();
            services.AddScoped<IValidator<InformationListUpdateDTO>, InformationListUpdateValidation>();

            services.AddScoped<IValidator<InternshipCreateDTO>, InternshipCreateValidation>();
            services.AddScoped<IValidator<InternshipUpdateDTO>, InternshipUpdateValidation>();

            services.AddScoped<IValidator<LessonCreateDTO>, LessonCreateValidation>();
            services.AddScoped<IValidator<LessonUpdateDTO>, LessonUpdateValidation>();

            services.AddScoped<IValidator<MeetingCreateDTO>, MeetingCreateValidation>();
            services.AddScoped<IValidator<MeetingUpdateDTO>, MeetingUpdateValidation>();

            services.AddScoped<IValidator<MessageCreateDTO>, MessageCreateValidation>();
            services.AddScoped<IValidator<MessageUpdateDTO>, MessageUpdateValidation>();

            services.AddScoped<IValidator<PositionCreateDTO>, PositionCreateValidation>();
            services.AddScoped<IValidator<PositionUpdateDTO>, PositionUpdateValidation>();

            services.AddScoped<IValidator<RegisterBlankCreateDTO>, RegisterBlankCreateValidation>();
            services.AddScoped<IValidator<RegisterBlankUpdateDTO>, RegisterBlankUpdateValidation>();

            services.AddScoped<IValidator<RoleCreateDTO>, RoleCreateValidation>();
            services.AddScoped<IValidator<RoleUpdateDTO>, RoleUpdateValidation>();

            services.AddScoped<IValidator<SatisfactionCreateDTO>, SatisfactionCreateValidation>();
            services.AddScoped<IValidator<SatisfactionUpdateDTO>, SatisfactionUpdateValidation>();

            services.AddScoped<IValidator<StudentCreateDTO>, StudentCraeteValidation>();
            services.AddScoped<IValidator<StudentUpdateDTO>, StudentUpdateValidation>();

            services.AddScoped<IValidator<StudentPaymentCreateDTO>, StudentPaymentCreateValidation>();
            services.AddScoped<IValidator<StudentPaymentUpdateDTO>, StudentPaymentUpdateValidation>();

            services.AddScoped<IValidator<TaskCreateDTO>, TaskCreateValidation>();
            services.AddScoped<IValidator<TaskUpdateDTO>, TaskUpdateValidation>();

            services.AddScoped<IValidator<UserCreateDTO>, UserCreateValidation>();
            services.AddScoped<IValidator<UserUpdateDTO>, UserUpdateValidation>();

            services.AddScoped<IValidator<UserAttendanceCreateDTO>, UserAttendanceCreateValidation>();
            services.AddScoped<IValidator<UserAttendanceUpdateDTO>, UserAttendanceUpdateValidation>();
        }
    }
}
