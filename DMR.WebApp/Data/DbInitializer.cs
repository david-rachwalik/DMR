using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using DMR.WebApp.Data.Seeds;
using DMR.WebApp.Models;

namespace DMR.WebApp.Data
{
    public static class DbInitializer
    {
        public static void Initialize(MainContext context)
        {
            Seed(context);
        }

        public static void Seed(MainContext context)
        {
            MovieSeed.Initialize(context);
            StudentSeed.Initialize(context);
            InstructorSeed.Initialize(context);
            DepartmentSeed.Initialize(context);
            CourseSeed.Initialize(context);
            OfficeAssignmentSeed.Initialize(context);
            CourseAssignmentSeed.Initialize(context);
            EnrollmentSeed.Initialize(context);
        }
    }
}