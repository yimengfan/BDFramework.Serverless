using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BitSprite.Helper;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace WebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //mongo
            try
            {
                Log.WriteLine("1.正在连接DB!" , ConsoleColor.Yellow);
                Log.WriteLine("---->DB启动成功! [1/5]" , ConsoleColor.Green);
            }
            catch (Exception e)
            {
                Log.WriteLine("\n 数据库连接失败! \n" + e.ToString() , ConsoleColor.Red);
            }
            //web
            try
            {

                Log.WriteLine("2.启动Web服务器", ConsoleColor.Yellow);
                WebAPIHelper.StartWebService();
                Log.WriteLine("---->web服务器启动成功! [2/5]", ConsoleColor.Green);
            }
            catch (Exception e)
            {
                Log.WriteLine("web服务器启动失败! \n" + e.ToString(), ConsoleColor.Red);
            }
            //Test
            try
            {

                Log.WriteLine("3.测试服务可用性", ConsoleColor.Yellow);
                Log.WriteLine("---->测试服务可用性成功! [2/5]", ConsoleColor.Green);
            }
            catch (Exception e)
            {
                Log.WriteLine("测试服务可用性失败! \n" + e.ToString(), ConsoleColor.Red);
            }
        }
    }
}