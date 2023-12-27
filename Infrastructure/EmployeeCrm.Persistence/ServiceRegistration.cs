using EmployeeCrm.Application.Abstraction;
using EmployeeCrm.Application.Repositories;
using EmployeeCrm.Application.Repositories.Attendance;
using EmployeeCrm.Application.Repositories.Employee;
using EmployeeCrm.Application.Repositories.Expense;
using EmployeeCrm.Application.Repositories.ExpenseType;
using EmployeeCrm.Application.Repositories.Group;
using EmployeeCrm.Application.Repositories.InformationList;
using EmployeeCrm.Application.Repositories.Internship;
using EmployeeCrm.Application.Repositories.Lesson;
using EmployeeCrm.Application.Repositories.Meeting;
using EmployeeCrm.Application.Repositories.Message;
using EmployeeCrm.Application.Repositories.Position;
using EmployeeCrm.Application.Repositories.RegisterBlank;
using EmployeeCrm.Application.Repositories.Role;
using EmployeeCrm.Application.Repositories.Satisfaction;
using EmployeeCrm.Application.Repositories.Student;
using EmployeeCrm.Application.Repositories.StudentPayment;
using EmployeeCrm.Application.Repositories.Task;
using EmployeeCrm.Application.Repositories.User;
using EmployeeCrm.Persistence.Contexts;
using EmployeeCrm.Persistence.Repositories;
using EmployeeCrm.Persistence.Repositories.Employee;
using EmployeeCrm.Persistence.Repositories.Event;
using EmployeeCrm.Persistence.Repositories.Expense;
using EmployeeCrm.Persistence.Repositories.ExpenseType;
using EmployeeCrm.Persistence.Repositories.Group;
using EmployeeCrm.Persistence.Repositories.InformationList;
using EmployeeCrm.Persistence.Repositories.Internship;
using EmployeeCrm.Persistence.Repositories.Lesson;
using EmployeeCrm.Persistence.Repositories.Meeting;
using EmployeeCrm.Persistence.Repositories.Message;
using EmployeeCrm.Persistence.Repositories.Position;
using EmployeeCrm.Persistence.Repositories.RegisterBlank;
using EmployeeCrm.Persistence.Repositories.Role;
using EmployeeCrm.Persistence.Repositories.Satisfaction;
using EmployeeCrm.Persistence.Repositories.Student;
using EmployeeCrm.Persistence.Repositories.StudentPayment;
using EmployeeCrm.Persistence.Repositories.Task;
using EmployeeCrm.Persistence.Repositories.User;
using EmployeeCrm.Persistence.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrm.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistanceService(this IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(option => option.UseNpgsql(Configuration.ConnectionString));

            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddScoped<IEmployeeReadRepository, EmployeeReadRepository>();
            services.AddScoped<IEmployeeWriteRepository, EmployeeWriteRepository>();

            services.AddScoped<IEventService, EventService>();
            services.AddScoped<IEventReadRepository, EventReadRepository>();
            services.AddScoped<IEventWriteRepository, EventWriteRepository>();

            services.AddScoped<IExpenseTypeService, ExpenseTypeService>();
            services.AddScoped<IExpenseTypeReadRepository, ExpenseTypeReadRepository>();
            services.AddScoped<IExpenseTypeWriteRepository, ExpenseTypeWriteRepository>();

            services.AddScoped<IGroupService, GroupService>();
            services.AddScoped<IGroupReadRepository, GroupReadRepository>();
            services.AddScoped<IGroupWriteRepository, GroupWriteRepository>();

            services.AddScoped<IInformationListService, InformationListService>();
            services.AddScoped<IInformationListReadRepository, InformationListReadRepository>();
            services.AddScoped<IInformationListWriteRepository, InformationListWriteRepository>();

            services.AddScoped<IInternshipService, InternshipService>();
            services.AddScoped<IInternshipReadRepository, InternshipReadRepository>();
            services.AddScoped<IInternshipWriteRepository, InternshipWriteRepository>();

            services.AddScoped<ILessonService, LessonService>();
            services.AddScoped<ILessonReadRepository, LessonReadRepository>();
            services.AddScoped<ILessonWriteRepository, LessonWriteRepository>();

            services.AddScoped<IMeetingService, MeetingService>();
            services.AddScoped<IMeetingReadRepository, MeetingReadRepository>();
            services.AddScoped<IMeetingWriteRepository, MeetingWriteRepository>();

            services.AddScoped<IMessageService,MessageService>();
            services.AddScoped<IMessageReadRepository, MessageReadRepository>();
            services.AddScoped<IMessageWriteRepository, MessageWriteRepository>();

            services.AddScoped<IPositionService, PositionService>();
            services.AddScoped<IPositionReadRepository, PositionReadRepository>();
            services.AddScoped<IPositionWriteRepository, PositionWriteRepository>();

            services.AddScoped<IRegisterBlankService, RegisterBlankService>();
            services.AddScoped<IRegisterBlankReadRepository, RegisterBlankReadRepository>();
            services.AddScoped<IRegisterBlankWriteRepository, RegisterBlankWriteRepository>();

            services.AddScoped<IRoleService, RoleService>();
            services.AddScoped<IRoleReadRepository, RoleReadRepository>();
            services.AddScoped<IRoleWriteRepository, RoleWriteRepository>();

            services.AddScoped<ISatisfactionService, SatisfactionService>();
            services.AddScoped<ISatisfactionReadRepository, SatisfactionReadRepository>();
            services.AddScoped<ISatisfactionWriteRepository, SatisfactionWriteRepository>();

            services.AddScoped<IStudentService, StudentService>();
            services.AddScoped<IStudentReadRepository, StudentReadRepository>();
            services.AddScoped<IStudentWriteRepository, StudentWriteRepository>();

            services.AddScoped<IStudentPaymentService, StudentPaymentService>();
            services.AddScoped<IStudentPaymentReadRepository, StudentPaymentReadRepository>();
            services.AddScoped<IStudentPaymentWriteRepository, StudentPaymentWriteRepository>();

            services.AddScoped<ITaskService, TaskService>();
            services.AddScoped<ITaskReadRepository, TaskReadRepository>();
            services.AddScoped<ITaskWriteRepository, TaskWriteRepository>();

            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IUserReadRepository, UserReadRepository>();
            services.AddScoped<IUserWriteRepository, UserWriteRepository>();

            services.AddScoped<IUserAttendanceService, UserAttendanceService>();
            services.AddScoped<IUserAttendanceReadRepository, UserAttendanceReadRepository>();
            services.AddScoped<IUserAttendanceWriteRepository, UserAttendanceWriteRepository>();
        }
    }
}
