using System;
using System.Threading.Tasks;
using Microsoft.TeamFoundation.WorkItemTracking.WebApi;
using Microsoft.TeamFoundation.WorkItemTracking.WebApi.Models;
using Microsoft.VisualStudio.Services.Common;
using Microsoft.VisualStudio.Services.WebApi;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 3)
            {
                Uri orgUrl = new Uri(args[0]);         // Organization URL, for example: https://dev.azure.com/fabrikam               
                String personalAccessToken = args[1];  // See https://docs.microsoft.com/azure/devops/integrate/get-started/authentication/pats
                int workItemId = int.Parse(args[2]);   // ID of a work item, for example: 12

                // Create a connection
                VssConnection connection = new VssConnection(orgUrl, new VssBasicCredential(string.Empty, personalAccessToken));

                // Show details a work item
                ShowBuildUserDetails(connection, projectname).Wait();
            }
            else
            {
                Console.WriteLine("Usage: ConsoleApp {orgUrl} {personalAccessToken} {projectname}");
            }

        }

        static private async Task ShowBuildUserDetails(VssConnection connection, string projectname)
        {
            // Get Code for ShowBuildUserDetails*********
            

            try
            {
                //Code for ShowBuildUserDetails
            }
            catch (AggregateException aex)
            {
                VssServiceException vssex = aex.InnerException as VssServiceException;
                if (vssex != null)
                {
                    Console.WriteLine(vssex.Message);
                }
            }
        }
    }
}
