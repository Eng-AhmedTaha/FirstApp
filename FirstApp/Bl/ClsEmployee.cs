using FirstApp.Models;

namespace FirstApp.Bl
{
    public class ClsEmployee
    {
        public List<EmployeeModel> GetData()
        {
            var lstEmployees = new List<EmployeeModel>();
            EmployeeModel model = new EmployeeModel();
            model.Id = 1;
            model.Name = "Ahmed";
            model.Title = "Sales";
            model.Email = "aa@gmail.com";
            model.Description = "Very imprtant sales man";
            model.ImageName = "2.jpg";
            lstEmployees.Add(model);

            model = new EmployeeModel();
            model.Id = 2;
            model.Name = "Mohamed";
            model.Title = "Developer";
            model.Email = "aa1@gmail.com";
            model.Description = "Some text that describes me lorem ipsum ipsum lorem.<";
            model.ImageName = "1.jpg";
            lstEmployees.Add(model);

            model = new EmployeeModel();
            model.Id = 3;
            model.Name = "Omar";
            model.Title = "Team Lead";
            model.Email = "aa2@gmail.com";
            model.Description = "Strong Team Leaf";
            model.ImageName = "3.jpg";
            lstEmployees.Add(model);

            model = new EmployeeModel();
            model.Id = 4;
            model.Name = "Ramy";
            model.Title = "Techincal Lead";
            model.Email = "aa34@gmail.com";
            model.Description = "Very Kind Man";
            model.ImageName = "1.jpg";
            lstEmployees.Add(model);
            return lstEmployees;
        }

        public EmployeeModel Find(int id)
        {
            return new EmployeeModel();
        }


    }
}
