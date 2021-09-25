using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using VotingApp.Models.DbContext;

namespace VotingApp.DAL
{
    public class VotingDal
    {

        #region Common
        private readonly CellPhoneVotingEntities _context;

        public VotingDal(CellPhoneVotingEntities context)
        {
            _context = context;
        }


        private SqlConnection GetConnectionSql()
        {
            //var connectionStringName = ConfigurationManager.ConnectionStrings["RBSYNERGYEntities"];
            //string connectionString = connectionStringName.ConnectionString;
            const string connectionString = @"Data Source = 192.168.2.123; Initial Catalog = CellPhoneVoting; user id=SA;password=r&d!@#456;";
            try
            {
                SqlConnection conCheck = new SqlConnection(connectionString);
                return new SqlConnection(connectionString);
            }
            catch (Exception e)
            {
                throw new Exception("Error : " + e.Message);
            }
        }

        #endregion

        //public async Task<int> AddOrEditPole(string PloesName, DateTime StartDate, DateTime EndDate, bool Status)
        //{
            //var data = await GetABpByMobileNumber(BpPhoneNumber);

            //if (data == null)
            //{
                //_context.Database.CommandTimeout = 6000;
                //string Sql = " Insert into [CellPhoneVoting].[dbo].[tblPoles] " +
                //             " (PloesName,StartDate,EndDate,[Status]) " +
                //             " values ('" + PloesName + "','" + StartDate + "','" + EndDate + "','" + Status + " ) ";

                //var savedata = await _context.Database.ExecuteSqlCommandAsync(Sql);
                //return savedata;
            //}
            //else
            //{
            //    _context.Database.CommandTimeout = 6000;
            //    string Sql = " Update [BrandPromotion].[dbo].[BPInfo] set Active='" + IsActive + "',CreatedBy='25740' where BPPhoneNumber='" + BpPhoneNumber + "' ";

            //    var savedata = await _context.Database.ExecuteSqlCommandAsync(Sql);
            //    return savedata;
            //}
        //}

    }
}