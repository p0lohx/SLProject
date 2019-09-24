using System;

namespace SLProject.SLCompilerLib.Parser{
    public class ReflectionContext : IReflectionContext{
        object context;

        public ReflectionContext(object context){
            this.context = context;
        }

        public double ResolveVariable(string name){
            var prop = context.GetType().GetProperty(name);
            if(prop == null)
                throw new Exception($"Unknown variable named \"{name}\" !");
            var value = (double)prop.GetValue(context);
            return value;
        }
    }
}