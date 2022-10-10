using CrudAngular2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CrudAngular2.Controllers
{
    [RoutePrefix("Api/Employee")]
    public class CRUDAPIController : ApiController
    {
        CrudAngularEntities objEntity = new CrudAngularEntities();

        [HttpGet]
        [Route("AllEmployeeDetails")]

        public IQueryable<EmployeeDetail> GetEmployees()
        {
            try
            {
                return objEntity.EmployeeDetails;
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet]
        [Route("GetEmployeeDetailsById/{employeeId}")]

        public IHttpActionResult GetEmployeeById(string employeeId)
        {
            EmployeeDetail objEmp = new EmployeeDetail();
            int ID = Convert.ToInt32(employeeId);
            try
            {
                objEmp = objEntity.EmployeeDetails.Find(ID);
                if(objEmp == null)
                {
                    return NotFound();
                }
            }
            catch(Exception)
            {
                throw;
            }
            return Ok(objEmp); 
        } 

        [HttpPost]
        [Route("InsertEmployeeDetails")]

        public IHttpActionResult PostEmployee(EmployeeDetail data)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                objEntity.EmployeeDetails.Add(data);
                objEntity.SaveChanges();

            }
            catch (Exception)
            {
                throw;
            }
            return Ok(data);
        }

        [HttpPut]
        [Route("UpdateEmployeeDetails")]

        public IHttpActionResult PutEmployeeMaster(EmployeeDetail employee)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                EmployeeDetail objEmp = new EmployeeDetail();
                objEmp = objEntity.EmployeeDetails.Find(employee.EmpId);
                if (objEmp != null)
                {
                    objEmp.EmpName = employee.EmpName;
                    objEmp.Address = employee.Address;
                    objEmp.Emailid = employee.Emailid;
                    objEmp.DateOfBirth = employee.DateOfBirth;
                    objEmp.Gender = employee.Gender;
                    objEmp.pinCode = employee.pinCode;

                }
                int i = this.objEntity.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
            return Ok(employee);
        } 

        [HttpDelete]
        [Route("DeleteEmployeeDetails")]

        public IHttpActionResult DeleteEmaployeeDelete(int id)
        {
            EmployeeDetail employee = objEntity.EmployeeDetails.Find(id);
            if (employee == null)
            {
                return NotFound();
            }
            objEntity.EmployeeDetails.Remove(employee);
            objEntity.SaveChanges();
            return Ok(employee);
        }
    }
}
