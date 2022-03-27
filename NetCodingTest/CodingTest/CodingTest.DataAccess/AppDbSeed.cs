using CodingTest.Models.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingTest.DataAccess
{
    public class AppDbSeed
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ProjectDbContext>();

                context.Database.EnsureCreated();

                if (!context.Employee.Any())
                {
                    context.Employee.AddRange(new List<Employee>()
                    {
                        new Employee()
                        {
                            FullName="Employee One",
                            MobilePhone=1233456,
                            Email="employee1@mail.com",
                            EmployeeNum=1,
                            

                        },

                         new Employee()
                        {
                            FullName="Employee Two",
                            MobilePhone=2,
                            Email="employee2@mail.com",
                            EmployeeNum=2

                        }

                    });

                   
                    context.SaveChanges();
                };

                if (!context.Client.Any())
                {
                    context.Client.AddRange(new List<Client>()
                    {
                        new Client()
                        {
                            FullName="Client One",
                            Mobile=1233456,
                            Email="client1@mail.com",
                            Company="CompanyOne"

                        },
                         new Client()
                        {
                            FullName="Client Two",
                            Mobile=2,
                            Email="client2@mail.com",
                            Company="CompanyTwo"

                        }

                    });
                   
                    context.SaveChanges();
                };
                if (!context.Project.Any())
                {
                    context.Project.AddRange(new List<Project>()
                    {
                        new Project()
                        {
                            NameProject="First Project",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(10),
                            ClientId=1,

                        },
                          new Project()
                        {
                            NameProject="Second Project",
                            StartDate = DateTime.Now.AddDays(-12),
                            EndDate = DateTime.Now.AddDays(12),
                            ClientId=2,

                        }

                    });
                   
                    context.SaveChanges();
                };
                if (!context.ProjectEmployee.Any())
                {
                    context.ProjectEmployee.AddRange(new List<ProjectEmployeeClient>()
                    {
                        new ProjectEmployeeClient()
                        {
                            
                            EmployeeId=1,
                            ProjectId=1,

                        },
                        new ProjectEmployeeClient()
                        {

                            EmployeeId=2,
                            ProjectId=2,


                        },

                    });
                    
                    context.SaveChanges();
                };
            }
        }
    }
}
