using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;

namespace XLAPI_CONSOLE.XLControllers
{
    public class XLReflection
    {
        [STAThread]
        public static object GetInstance(string strFullyQualifiedName)
        {
            Type type = Type.GetType(strFullyQualifiedName);
            if (type != null)
                return Activator.CreateInstance(type);
            foreach (var asm in AppDomain.CurrentDomain.GetAssemblies())
            {
                type = asm.GetType(strFullyQualifiedName);
                if (type != null)
                    return Activator.CreateInstance(type);
            }
            return null;
        }
        [STAThread]
        public static object CreateObjectInstance(string className, Dictionary<string, object> Properties)
        {
            object obj = XLReflection.GetInstance(className);
            if (obj != null)
            {
                foreach (var item in Properties)
                    XLReflection.SetField(obj, item.Key, item.Value);
            }

            else
            {
                Console.WriteLine($"Nie znaleziono metody {className} w przestrzeni nazw");
            }

            return obj;
        }
        [STAThread]
        public static object CreateObjectInstance<T>(string className, T MappingObject)
        {
            if (MappingObject == null)
                return null;

            object obj = XLReflection.GetInstance(className);
            if (obj != null)
            {
                var properties = MappingObject.GetType().GetProperties();
                foreach (var property in properties)
                {
                    object value = property.GetValue(MappingObject);
                    if (value != null)
                    {
                        XLReflection.SetField(obj, property.Name, value);
                    }
                }
            }

            else
            {
                Console.WriteLine($"Nie znaleziono metody {className} w przestrzeni nazw");
            }

            return obj;
        }
        private static readonly object lockObject = new object();

        private static readonly SemaphoreSlim semaphoreSlim = new SemaphoreSlim(1, 1);

        [STAThread]
        //  [SuppressMessage("Microsoft.Performance", "CA1416:ValidatePlatformCompatibility")]
        public static int GetMethodAndInvoke(string methodName, object[] args, ref Type CdnApiType)
        {
            // Console.WriteLine($"Metoda {nameof(GetMethodAndInvoke)} działa na wątku o ID: {Environment.CurrentManagedThreadId}");
            //object comObject = null;
            int result = -999999;
            lock (lockObject)
            {
                MethodInfo method = CdnApiType.GetMethod(methodName, BindingFlags.Static | BindingFlags.Public);
                if (method != null)
                {
                    try
                    {
                        semaphoreSlim.Wait(); // Czekaj na dostęp do semafora

                        var comObject = method.Invoke(null, args);
                        if (comObject != null)
                            _ = int.TryParse(comObject.ToString(), out result);
                    }
                    catch (TargetInvocationException ex)
                    {
                        Console.WriteLine(methodName + ":> ex getmethod TargetInvocationException" + ex.Message);
                        Console.WriteLine(methodName + ":> ex getmethod TargetInvocationException" + ex.InnerException);
                    }
                    catch (SEHException ex)
                    {
                        Console.WriteLine(methodName + ":> :> ex getmethod SEHException " + ex.Message);
                        Console.WriteLine(methodName + ":> ex getmethod SEHException " + ex.InnerException);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(methodName + ":> ex getmethod Exception" + ex.Message);
                        Console.WriteLine(methodName + ":> ex getmethod Exception" + ex.InnerException);
                    }
                    finally
                    {
                        //if (comObject != null)
                        //{
                        // //  Marshal.ReleaseComObject(comObject);
                        //}
                        semaphoreSlim.Release(); // Zwolnij semafor po zakończeniu operacji

                    }
                }
                else
                {
                    Console.WriteLine($"Nie znaleziono metody {methodName} w klasie cdn_api");
                }
            }
            return result;
        }

        public static void SetField(object obj, string fieldName, object value)
        {
            if (obj != null)
            {
                FieldInfo field = obj.GetType().GetField(fieldName, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
                field?.SetValue(obj, value);
            }
        }

        public static object GetField(object obj, string propertyName)
        {
            object getValue = null;
            if (obj != null)
            {
                FieldInfo field = obj.GetType().GetField(propertyName);
                if (field != null)
                    getValue = field.GetValue(obj);
            }
            return getValue;
        }


        public static object GetProperty(object obj, string propertyName)
        {
            object getValue = null;
            if (obj != null)
            {
                PropertyInfo property = obj.GetType().GetProperty(propertyName);
                if (property != null)
                    getValue = property.GetValue(obj);
            }
            return getValue;
        }
    }
}
