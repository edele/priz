using System;
using System.Collections.Generic;
using System.Text;

namespace PRIZ
{
    class Report
    {
        /// <summary> Пользователь, решавший эту задачу </summary>
        private User _user;
        /// <summary> Решенное задание </summary>
        private Answer answers;
        /// <summary>
        /// Метод отправляет на электронную почту все гипотезы по заданию
        /// и комментарий пользователя к ним.
        /// </summary>
        /// <param name="address">Адрес, на который отправляется отчет</param>
        /// <param name="text">Дополнительный комментарий пользователья, который включается в отчет</param>
        /// <param name="numberOfSentHypos">Количество отправляемых гипотез. 
        /// (пользователь сортирует их по качеству, а потом может указать, что в отчет должны быть 
        /// включены не все, а только 5 или 10 сверху)</param>
        void SendTaskViaEmail(string address, string text, int numberOfSentHypos = 0)
        {

        }
    }
}
