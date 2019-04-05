using System;
using System.Collections.Generic;

namespace AddingSitesToBlackList
{
    /// <summary>
    /// Добавление сайтов в черный список Единого Реестра
    /// </summary>
    public class AddingSitesToBlackList
    {
        /// <summary>
        /// Список сайтов
        /// </summary>
        public List<Sites> Sites { get; set; }

        /// <summary>
        /// Дата блокировки
        /// </summary>
        public DateTime BlockDate { get; set; }
    }

    /// <summary>
    /// Возможные статусы
    /// </summary>
    public enum Status
    {
        /// <summary>
        /// Работает
        /// </summary>
        run,

        /// <summary>
        /// Заблокирован
        /// </summary>
        blocked,

        /// <summary>
        /// На рассмотрении
        /// </summary>
        notSolved
    }

    /// <summary>
    /// Класс сайтов
    /// </summary>
    public class Sites
    {
        /// <summary>
        /// Адрес сайта
        /// </summary>
        public string Adress { get; set; }
        
        /// <summary>
        /// Адрес публикации
        /// </summary>
        public string AdressPubl { get; set; }

        /// <summary>
        /// Причина
        /// </summary>
        public string Reason { get; set; }

        /// <summary>
        /// Список нарушений
        /// </summary>
        public List<string> Violations = new List<string>()
        {
            "Экстремизм", "Угрозы к свержению власти", "Нарушение авторских прав", "Нарушение тайны частной жизни", "Раскрытие гостайны"
        };
        
        /// <summary>
        /// Дата отправки 
        /// </summary>
        public DateTime SendingDay { get; set; }

        /// <summary>
        /// Возможная дата нарушения
        /// </summary>
        public DateTime PublishDate { get; set; }

        /// <summary>
        /// Скриншот прилагаемый
        /// </summary>
        public byte[] Screenshot { get; set; }

        /// <summary>
        /// Статус сайта
        /// </summary>
        public Status Status { get; set; }
    }
}
