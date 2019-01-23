using System.Collections;

namespace Jackyfei.Framework.Contract.Util
{
    /// <summary>
    /// 链式契约验证
    /// </summary>
    public static class FluentContractValidator
    {
        /// <summary>
        /// 开始一个验证链
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static ValidatorContainer BeginValidator(this object obj)
        {
            return new ValidatorContainer() { ValidatorObj = obj };
        }

        /// <summary>
        /// 验证对象是否为空或NULL
        /// </summary>
        /// <param name="container"></param>
        /// <returns></returns>
        public static ValidatorContainer IsNullOrEmpty(this ValidatorContainer container)
        {
            container.Add(new Validator()
            {
                Container = container,
                Validat = (object obj) =>
                {
                    if (obj == null) return false;
                    else if (obj is string)
                    {
                        return !string.IsNullOrEmpty(obj.ToString());
                    }
                    else if (obj is IEnumerable)
                    {
                        return (obj as IEnumerable).GetEnumerator().MoveNext();
                    }
                    return true;
                }

            });

            return container;
        }

        public static ValidatorContainer StartsWith(this ValidatorContainer container, string str)
        {
            container.Add(new Validator()
            {
                Container = container,
                Validat = (object obj) =>
                {
                    if (obj == null) return false;
                    return (obj as string).StartsWith(str);
                }
            });
            return container;
        }

        public static ValidatorContainer EndValidator(this ValidatorContainer container)
        {
            return container;
        }

    }
}