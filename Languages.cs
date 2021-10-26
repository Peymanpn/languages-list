namespace Locales
{
    public class LanguageList
    {
        public class Language
        {
            public string Name { get; set; }
            public string Charset { get; set; }
        }

        public IDictionary<string, Language> Languages => new Dictionary<string, Language>
                {
                    {
                        "af_NA",
                        new Language
                        {
                            Name = "Afrikaans (Namibia)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "af_ZA",
                        new Language
                        {
                            Name = "Afrikaans (South Africa)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "af",
                        new Language
                        {
                            Name = "Afrikaans",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "ak_GH",
                        new Language
                        {
                            Name = "Akan (Ghana)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "ak",
                        new Language
                        {
                            Name = "Akan",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "sq_AL",
                        new Language
                        {
                            Name = "Albanian (Albania)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "sq",
                        new Language
                        {
                            Name = "Albanian",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "am_ET",
                        new Language
                        {
                            Name = "Amharic (Ethiopia)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "am",
                        new Language
                        {
                            Name = "Amharic",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "ar_DZ",
                        new Language
                        {
                            Name = "Arabic (Algeria)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "ar_BH",
                        new Language
                        {
                            Name = "Arabic (Bahrain)",
                            Charset = "ISO-8859-6"
                        }
                    },
                    {
                        "ar_EG",
                        new Language
                        {
                            Name = "Arabic (Egypt)",
                            Charset = "ISO-8859-6"
                        }
                    },
                    {
                        "ar_IQ",
                        new Language
                        {
                            Name = "Arabic (Iraq)",
                            Charset = "ISO-8859-6"
                        }
                    },
                    {
                        "ar_JO",
                        new Language
                        {
                            Name = "Arabic (Jordan)",
                            Charset = "ISO-8859-6"
                        }
                    },
                    {
                        "ar_KW",
                        new Language
                        {
                            Name = "Arabic (Kuwait)",
                            Charset = "ISO-8859-6"
                        }
                    },
                    {
                        "ar_LB",
                        new Language
                        {
                            Name = "Arabic (Lebanon)",
                            Charset = "ISO-8859-6"
                        }
                    },
                    {
                        "ar_LY",
                        new Language
                        {
                            Name = "Arabic (Libya)",
                            Charset = "ISO-8859-6"
                        }
                    },
                    {
                        "ar_MA",
                        new Language
                        {
                            Name = "Arabic (Morocco)",
                            Charset = "ISO-8859-6"
                        }
                    },
                    {
                        "ar_OM",
                        new Language
                        {
                            Name = "Arabic (Oman)",
                            Charset = "ISO-8859-6"
                        }
                    },
                    {
                        "ar_QA",
                        new Language
                        {
                            Name = "Arabic (Qatar)",
                            Charset = "ISO-8859-6"
                        }
                    },
                    {
                        "ar_SA",
                        new Language
                        {
                            Name = "Arabic (Saudi Arabia)",
                            Charset = "ISO-8859-6"
                        }
                    },
                    {
                        "ar_SD",
                        new Language
                        {
                            Name = "Arabic (Sudan)",
                            Charset = "ISO-8859-6"
                        }
                    },
                    {
                        "ar_SY",
                        new Language
                        {
                            Name = "Arabic (Syria)",
                            Charset = "ISO-8859-6"
                        }
                    },
                    {
                        "ar_TN",
                        new Language
                        {
                            Name = "Arabic (Tunisia)",
                            Charset = "ISO-8859-6"
                        }
                    },
                    {
                        "ar_AE",
                        new Language
                        {
                            Name = "Arabic (United Arab Emirates)",
                            Charset = "ISO-8859-6"
                        }
                    },
                    {
                        "ar_YE",
                        new Language
                        {
                            Name = "Arabic (Yemen)",
                            Charset = "ISO-8859-6"
                        }
                    },
                    {
                        "ar",
                        new Language
                        {
                            Name = "Arabic",
                            Charset = "ISO-8859-6"
                        }
                    },
                    {
                        "hy_AM",
                        new Language
                        {
                            Name = "Armenian (Armenia)",
                            Charset = "ARMSCII-8"
                        }
                    },
                    {
                        "hy",
                        new Language
                        {
                            Name = "Armenian",
                            Charset = "ARMSCII-8"
                        }
                    },
                    {
                        "as_IN",
                        new Language
                        {
                            Name = "Assamese (India)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "as",
                        new Language
                        {
                            Name = "Assamese",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "asa_TZ",
                        new Language
                        {
                            Name = "Asu (Tanzania)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "asa",
                        new Language
                        {
                            Name = "Asu",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "az_Cyrl",
                        new Language
                        {
                            Name = "Azerbaijani (Cyrillic, Azerbaijan)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "az_Cyrl_AZ",
                        new Language
                        {
                            Name = "Azerbaijani (Cyrillic, Azerbaijan)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "az_Latn",
                        new Language
                        {
                            Name = "Azerbaijani (Latin)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "az_Latn_AZ",
                        new Language
                        {
                            Name = "Azerbaijani (Latin, Azerbaijan)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "az",
                        new Language
                        {
                            Name = "Azerbaijani",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "bm_ML",
                        new Language
                        {
                            Name = "Bambara (Mali)",
                            Charset = "iso-8859-1"
                        }
                    },
                    {
                        "bm",
                        new Language
                        {
                            Name = "Bambara",
                            Charset = "iso-8859-1"
                        }
                    },
                    {
                        "eu_ES",
                        new Language
                        {
                            Name = "Basque (Spain)",
                            Charset = "ISO-8859-1"
                        }
                    },
                    {
                        "eu",
                        new Language
                        {
                            Name = "Basque",
                            Charset = "ISO-8859-1"
                        }
                    },
                    {
                        "be_BY",
                        new Language
                        {
                            Name = "Belarusian (Belarus)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "be",
                        new Language
                        {
                            Name = "Belarusian",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "bem_ZM",
                        new Language
                        {
                            Name = "Bemba (Zambia)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "bem",
                        new Language
                        {
                            Name = "Bemba",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "bez_TZ",
                        new Language
                        {
                            Name = "Bena (Tanzania)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "bez",
                        new Language
                        {
                            Name = "Bena",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "bn_BD",
                        new Language
                        {
                            Name = "Bengali (Bangladesh)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "bn_IN",
                        new Language
                        {
                            Name = "Bengali (India)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "bn",
                        new Language
                        {
                            Name = "Bengali",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "bs_BA",
                        new Language
                        {
                            Name = "Bosnian (Bosnia and Herzegovina)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "bs",
                        new Language
                        {
                            Name = "Bosnian",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "bg_BG",
                        new Language
                        {
                            Name = "Bulgarian (Bulgaria)",
                            Charset = "ISO-8859-2"
                        }
                    },
                    {
                        "bg",
                        new Language
                        {
                            Name = "Bulgarian",
                            Charset = "ISO-8859-2"
                        }
                    },
                    {
                        "my_MM",
                        new Language
                        {
                            Name = "Burmese (Myanmar [Burma])",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "my",
                        new Language
                        {
                            Name = "Burmese",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "yue_Hant_HK",
                        new Language
                        {
                            Name = "Cantonese (Traditional, Hong Kong SAR China)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "ca_ES",
                        new Language
                        {
                            Name = "Catalan (Spain)",
                            Charset = "ISO-8859-15"
                        }
                    },
                    {
                        "ca",
                        new Language
                        {
                            Name = "Catalan",
                            Charset = "ISO-8859-15"
                        }
                    },
                    {
                        "tzm_Latn",
                        new Language
                        {
                            Name = "Central Morocco Tamazight (Latin)",
                            Charset = "ISO-8859-1"
                        }
                    },
                    {
                        "tzm_Latn_MA",
                        new Language
                        {
                            Name = "Central Morocco Tamazight (Latin, Morocco)",
                            Charset = "ISO-8859-1"
                        }
                    },
                    {
                        "tzm",
                        new Language
                        {
                            Name = "Central Morocco Tamazight",
                            Charset = "ISO-8859-1"
                        }
                    },
                    {
                        "chr_US",
                        new Language
                        {
                            Name = "Cherokee (United States)",
                            Charset = "U+13A0"
                        }
                    },
                    {
                        "chr",
                        new Language
                        {
                            Name = "Cherokee",
                            Charset = "U+13A0"
                        }
                    },
                    {
                        "cgg_UG",
                        new Language
                        {
                            Name = "Chiga (Uganda)",
                            Charset = "ISO-8859-1"
                        }
                    },
                    {
                        "cgg",
                        new Language
                        {
                            Name = "Chiga",
                            Charset = "ISO-8859-1"
                        }
                    },
                    {
                        "zh_Hans",
                        new Language
                        {
                            Name = "Chinese (Simplified Han)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "zh_Hans_CN",
                        new Language
                        {
                            Name = "Chinese (Simplified Han, China)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "zh_Hans_HK",
                        new Language
                        {
                            Name = "Chinese (Simplified Han, Hong Kong SAR China)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "zh_Hans_MO",
                        new Language
                        {
                            Name = "Chinese (Simplified Han, Macau SAR China)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "zh_Hans_SG",
                        new Language
                        {
                            Name = "Chinese (Simplified Han, Singapore)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "zh_Hant",
                        new Language
                        {
                            Name = "Chinese (Traditional Han)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "zh_Hant_HK",
                        new Language
                        {
                            Name = "Chinese (Traditional Han, Hong Kong SAR China)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "zh_Hant_MO",
                        new Language
                        {
                            Name = "Chinese (Traditional Han, Macau SAR China)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "zh_Hant_TW",
                        new Language
                        {
                            Name = "Chinese (Traditional Han, Taiwan)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "zh",
                        new Language
                        {
                            Name = "Chinese",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "kw_GB",
                        new Language
                        {
                            Name = "Cornish (United Kingdom)",
                            Charset = "ISO-8859-1"
                        }
                    },
                    {
                        "kw",
                        new Language
                        {
                            Name = "Cornish",
                            Charset = "ISO-8859-1"
                        }
                    },
                    {
                        "hr_HR",
                        new Language
                        {
                            Name = "Croatian (Croatia)",
                            Charset = "ISO-8859-2"
                        }
                    },
                    {
                        "hr",
                        new Language
                        {
                            Name = "Croatian",
                            Charset = "ISO-8859-2"
                        }
                    },
                    {
                        "cs_CZ",
                        new Language
                        {
                            Name = "Czech (Czech Republic)",
                            Charset = "ISO-8859-2"
                        }
                    },
                    {
                        "cs",
                        new Language
                        {
                            Name = "Czech",
                            Charset = "ISO-8859-2"
                        }
                    },
                    {
                        "da_DK",
                        new Language
                        {
                            Name = "Danish (Denmark)",
                            Charset = "ISO-8859-1"
                        }
                    },
                    {
                        "da",
                        new Language
                        {
                            Name = "Danish",
                            Charset = "ISO-8859-1"
                        }
                    },
                    {
                        "nl_BE",
                        new Language
                        {
                            Name = "Dutch (Belgium)",
                            Charset = "ISO-8859-15"
                        }
                    },
                    {
                        "nl_NL",
                        new Language
                        {
                            Name = "Dutch (Netherlands)",
                            Charset = "ISO-8859-15"
                        }
                    },
                    {
                        "nl",
                        new Language
                        {
                            Name = "Dutch",
                            Charset = "ISO-8859-15"
                        }
                    },
                    {
                        "ebu_KE",
                        new Language
                        {
                            Name = "Embu (Kenya)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "ebu",
                        new Language
                        {
                            Name = "Embu",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "en_AS",
                        new Language
                        {
                            Name = "English (American Samoa)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "en_AU",
                        new Language
                        {
                            Name = "English (Australia)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "en_BE",
                        new Language
                        {
                            Name = "English (Belgium)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "en_BZ",
                        new Language
                        {
                            Name = "English (Belize)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "en_BW",
                        new Language
                        {
                            Name = "English (Botswana)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "en_CA",
                        new Language
                        {
                            Name = "English (Canada)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "en_GU",
                        new Language
                        {
                            Name = "English (Guam)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "en_HK",
                        new Language
                        {
                            Name = "English (Hong Kong SAR China)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "en_IN",
                        new Language
                        {
                            Name = "English (India)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "en_IE",
                        new Language
                        {
                            Name = "English (Ireland)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "en_IL",
                        new Language
                        {
                            Name = "English (Israel)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "en_JM",
                        new Language
                        {
                            Name = "English (Jamaica)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "en_MT",
                        new Language
                        {
                            Name = "English (Malta)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "en_MH",
                        new Language
                        {
                            Name = "English (Marshall Islands)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "en_MU",
                        new Language
                        {
                            Name = "English (Mauritius)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "en_NA",
                        new Language
                        {
                            Name = "English (Namibia)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "en_NZ",
                        new Language
                        {
                            Name = "English (New Zealand)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "en_MP",
                        new Language
                        {
                            Name = "English (Northern Mariana Islands)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "en_PK",
                        new Language
                        {
                            Name = "English (Pakistan)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "en_PH",
                        new Language
                        {
                            Name = "English (Philippines)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "en_SG",
                        new Language
                        {
                            Name = "English (Singapore)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "en_ZA",
                        new Language
                        {
                            Name = "English (South Africa)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "en_TT",
                        new Language
                        {
                            Name = "English (Trinidad and Tobago)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "en_UM",
                        new Language
                        {
                            Name = "English (U.S. Minor Outlying Islands)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "en_VI",
                        new Language
                        {
                            Name = "English (U.S. Virgin Islands)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "en_GB",
                        new Language
                        {
                            Name = "English (United Kingdom)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "en_US",
                        new Language
                        {
                            Name = "English (United States)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "en_ZW",
                        new Language
                        {
                            Name = "English (Zimbabwe)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "en",
                        new Language
                        {
                            Name = "English",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "eo",
                        new Language
                        {
                            Name = "Esperanto",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "et_EE",
                        new Language
                        {
                            Name = "Estonian (Estonia)",
                            Charset = "ISO-8859-1"
                        }
                    },
                    {
                        "et",
                        new Language
                        {
                            Name = "Estonian",
                            Charset = "ISO-8859-1"
                        }
                    },
                    {
                        "ee_GH",
                        new Language
                        {
                            Name = "Ewe (Ghana)",
                            Charset = "ISO-8859-1"
                        }
                    },
                    {
                        "ee_TG",
                        new Language
                        {
                            Name = "Ewe (Togo)",
                            Charset = "ISO-8859-1"
                        }
                    },
                    {
                        "ee",
                        new Language
                        {
                            Name = "Ewe",
                            Charset = "ISO-8859-1"
                        }
                    },
                    {
                        "fo_FO",
                        new Language
                        {
                            Name = "Faroese (Faroe Islands)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "fo",
                        new Language
                        {
                            Name = "Faroese",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "fil_PH",
                        new Language
                        {
                            Name = "Filipino (Philippines)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "fil",
                        new Language
                        {
                            Name = "Filipino",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "fi_FI",
                        new Language
                        {
                            Name = "Finnish (Finland)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "fi",
                        new Language
                        {
                            Name = "Finnish",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "fr_BE",
                        new Language
                        {
                            Name = "French (Belgium)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "fr_BJ",
                        new Language
                        {
                            Name = "French (Benin)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "fr_BF",
                        new Language
                        {
                            Name = "French (Burkina Faso)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "fr_BI",
                        new Language
                        {
                            Name = "French (Burundi)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "fr_CM",
                        new Language
                        {
                            Name = "French (Cameroon)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "fr_CA",
                        new Language
                        {
                            Name = "French (Canada)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "fr_CF",
                        new Language
                        {
                            Name = "French (Central African Republic)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "fr_TD",
                        new Language
                        {
                            Name = "French (Chad)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "fr_KM",
                        new Language
                        {
                            Name = "French (Comoros)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "fr_CG",
                        new Language
                        {
                            Name = "French (Congo - Brazzaville)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "fr_CD",
                        new Language
                        {
                            Name = "French (Congo - Kinshasa)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "fr_CI",
                        new Language
                        {
                            Name = "French (Côte d’Ivoire)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "fr_DJ",
                        new Language
                        {
                            Name = "French (Djibouti)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "fr_GQ",
                        new Language
                        {
                            Name = "French (Equatorial Guinea)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "fr_FR",
                        new Language
                        {
                            Name = "French (France)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "fr_GA",
                        new Language
                        {
                            Name = "French (Gabon)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "fr_GP",
                        new Language
                        {
                            Name = "French (Guadeloupe)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "fr_GN",
                        new Language
                        {
                            Name = "French (Guinea)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "fr_LU",
                        new Language
                        {
                            Name = "French (Luxembourg)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "fr_MG",
                        new Language
                        {
                            Name = "French (Madagascar)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "fr_ML",
                        new Language
                        {
                            Name = "French (Mali)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "fr_MQ",
                        new Language
                        {
                            Name = "French (Martinique)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "fr_MC",
                        new Language
                        {
                            Name = "French (Monaco)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "fr_NE",
                        new Language
                        {
                            Name = "French (Niger)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "fr_RW",
                        new Language
                        {
                            Name = "French (Rwanda)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "fr_RE",
                        new Language
                        {
                            Name = "French (Réunion)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "fr_BL",
                        new Language
                        {
                            Name = "French (Saint Barthélemy)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "fr_MF",
                        new Language
                        {
                            Name = "French (Saint Martin)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "fr_SN",
                        new Language
                        {
                            Name = "French (Senegal)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "fr_CH",
                        new Language
                        {
                            Name = "French (Switzerland)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "fr_TG",
                        new Language
                        {
                            Name = "French (Togo)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "fr",
                        new Language
                        {
                            Name = "French",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "ff_SN",
                        new Language
                        {
                            Name = "Fulah (Senegal)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "ff",
                        new Language
                        {
                            Name = "Fulah",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "gl_ES",
                        new Language
                        {
                            Name = "Galician (Spain)",
                            Charset = "ISO-8859-1"
                        }
                    },
                    {
                        "gl",
                        new Language
                        {
                            Name = "Galician",
                            Charset = "ISO-8859-1"
                        }
                    },
                    {
                        "lg_UG",
                        new Language
                        {
                            Name = "Ganda (Uganda)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "lg",
                        new Language
                        {
                            Name = "Ganda",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "ka_GE",
                        new Language
                        {
                            Name = "Georgian (Georgia)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "ka",
                        new Language
                        {
                            Name = "Georgian",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "de_AT",
                        new Language
                        {
                            Name = "German (Austria)",
                            Charset = "ISO-8859-1"
                        }
                    },
                    {
                        "de_BE",
                        new Language
                        {
                            Name = "German (Belgium)",
                            Charset = "ISO-8859-1"
                        }
                    },
                    {
                        "de_DE",
                        new Language
                        {
                            Name = "German (Germany)",
                            Charset = "ISO-8859-1"
                        }
                    },
                    {
                        "de_LI",
                        new Language
                        {
                            Name = "German (Liechtenstein)",
                            Charset = "ISO-8859-1"
                        }
                    },
                    {
                        "de_LU",
                        new Language
                        {
                            Name = "German (Luxembourg)",
                            Charset = "ISO-8859-1"
                        }
                    },
                    {
                        "de_CH",
                        new Language
                        {
                            Name = "German (Switzerland)",
                            Charset = "ISO-8859-1"
                        }
                    },
                    {
                        "de",
                        new Language
                        {
                            Name = "German",
                            Charset = "ISO-8859-1"
                        }
                    },
                    {
                        "el_CY",
                        new Language
                        {
                            Name = "Greek (Cyprus)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "el_GR",
                        new Language
                        {
                            Name = "Greek (Greece)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "el",
                        new Language
                        {
                            Name = "Greek",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "gu_IN",
                        new Language
                        {
                            Name = "Gujarati (India)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "gu",
                        new Language
                        {
                            Name = "Gujarati",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "guz_KE",
                        new Language
                        {
                            Name = "Gusii (Kenya)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "guz",
                        new Language
                        {
                            Name = "Gusii",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "ha_Latn",
                        new Language
                        {
                            Name = "Hausa (Latin)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "ha_Latn_GH",
                        new Language
                        {
                            Name = "Hausa (Latin, Ghana)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "ha_Latn_NE",
                        new Language
                        {
                            Name = "Hausa (Latin, Niger)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "ha_Latn_NG",
                        new Language
                        {
                            Name = "Hausa (Latin, Nigeria)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "ha",
                        new Language
                        {
                            Name = "Hausa",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "haw_US",
                        new Language
                        {
                            Name = "Hawaiian (United States)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "haw",
                        new Language
                        {
                            Name = "Hawaiian",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "he_IL",
                        new Language
                        {
                            Name = "Hebrew (Israel)",
                            Charset = "ISO-8859-8"
                        }
                    },
                    {
                        "he",
                        new Language
                        {
                            Name = "Hebrew",
                            Charset = "ISO-8859-8"
                        }
                    },
                    {
                        "hi_IN",
                        new Language
                        {
                            Name = "Hindi (India)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "hi",
                        new Language
                        {
                            Name = "Hindi",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "hu_HU",
                        new Language
                        {
                            Name = "Hungarian (Hungary)",
                            Charset = "ISO-8859-2"
                        }
                    },
                    {
                        "hu",
                        new Language
                        {
                            Name = "Hungarian",
                            Charset = "ISO-8859-2"
                        }
                    },
                    {
                        "is_IS",
                        new Language
                        {
                            Name = "Icelandic (Iceland)",
                            Charset = "ISO-8859-1"
                        }
                    },
                    {
                        "is",
                        new Language
                        {
                            Name = "Icelandic",
                            Charset = "ISO-8859-1"
                        }
                    },
                    {
                        "ig_NG",
                        new Language
                        {
                            Name = "Igbo (Nigeria)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "ig",
                        new Language
                        {
                            Name = "Igbo",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "id_ID",
                        new Language
                        {
                            Name = "Indonesian (Indonesia)",
                            Charset = "ISO-8859-1"
                        }
                    },
                    {
                        "id",
                        new Language
                        {
                            Name = "Indonesian",
                            Charset = "ISO-8859-1"
                        }
                    },
                    {
                        "ga_IE",
                        new Language
                        {
                            Name = "Irish (Ireland)",
                            Charset = "ISO-8859-1"
                        }
                    },
                    {
                        "ga",
                        new Language
                        {
                            Name = "Irish",
                            Charset = "ISO-8859-1"
                        }
                    },
                    {
                        "it_IT",
                        new Language
                        {
                            Name = "Italian (Italy)",
                            Charset = "ISO-8859-1"
                        }
                    },
                    {
                        "it_CH",
                        new Language
                        {
                            Name = "Italian (Switzerland)",
                            Charset = "ISO-8859-1"
                        }
                    },
                    {
                        "it",
                        new Language
                        {
                            Name = "Italian",
                            Charset = "ISO-8859-1"
                        }
                    },
                    {
                        "ja_JP",
                        new Language
                        {
                            Name = "Japanese (Japan)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "ja",
                        new Language
                        {
                            Name = "Japanese",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "kea_CV",
                        new Language
                        {
                            Name = "Kabuverdianu (Cape Verde)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "kea",
                        new Language
                        {
                            Name = "Kabuverdianu",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "kab_DZ",
                        new Language
                        {
                            Name = "Kabyle (Algeria)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "kab",
                        new Language
                        {
                            Name = "Kabyle",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "kl_GL",
                        new Language
                        {
                            Name = "Kalaallisut (Greenland)",
                            Charset = "ISO-8859-1"
                        }
                    },
                    {
                        "kl",
                        new Language
                        {
                            Name = "Kalaallisut",
                            Charset = "ISO-8859-1"
                        }
                    },
                    {
                        "kln_KE",
                        new Language
                        {
                            Name = "Kalenjin (Kenya)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "kln",
                        new Language
                        {
                            Name = "Kalenjin",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "kam_KE",
                        new Language
                        {
                            Name = "Kamba (Kenya)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "kam",
                        new Language
                        {
                            Name = "Kamba",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "kn_IN",
                        new Language
                        {
                            Name = "Kannada (India)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "kn",
                        new Language
                        {
                            Name = "Kannada",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "kk_Cyrl",
                        new Language
                        {
                            Name = "Kazakh (Cyrillic)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "kk_Cyrl_KZ",
                        new Language
                        {
                            Name = "Kazakh (Cyrillic, Kazakhstan)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "kk",
                        new Language
                        {
                            Name = "Kazakh",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "km_KH",
                        new Language
                        {
                            Name = "Khmer (Cambodia)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "km",
                        new Language
                        {
                            Name = "Khmer",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "ki_KE",
                        new Language
                        {
                            Name = "Kikuyu (Kenya)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "ki",
                        new Language
                        {
                            Name = "Kikuyu",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "rw_RW",
                        new Language
                        {
                            Name = "Kinyarwanda (Rwanda)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "rw",
                        new Language
                        {
                            Name = "Kinyarwanda",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "kok_IN",
                        new Language
                        {
                            Name = "Konkani (India)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "kok",
                        new Language
                        {
                            Name = "Konkani",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "ko_KR",
                        new Language
                        {
                            Name = "Korean (South Korea)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "ko",
                        new Language
                        {
                            Name = "Korean",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "khq_ML",
                        new Language
                        {
                            Name = "Koyra Chiini (Mali)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "khq",
                        new Language
                        {
                            Name = "Koyra Chiini",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "ses_ML",
                        new Language
                        {
                            Name = "Koyraboro Senni (Mali)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "ses",
                        new Language
                        {
                            Name = "Koyraboro Senni",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "lag_TZ",
                        new Language
                        {
                            Name = "Langi (Tanzania)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "lag",
                        new Language
                        {
                            Name = "Langi",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "lv_LV",
                        new Language
                        {
                            Name = "Latvian (Latvia)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "lv",
                        new Language
                        {
                            Name = "Latvian",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "lt_LT",
                        new Language
                        {
                            Name = "Lithuanian (Lithuania)",
                            Charset = "ISO-8859-13"
                        }
                    },
                    {
                        "lt",
                        new Language
                        {
                            Name = "Lithuanian",
                            Charset = "ISO-8859-13"
                        }
                    },
                    {
                        "luo_KE",
                        new Language
                        {
                            Name = "Luo (Kenya)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "luo",
                        new Language
                        {
                            Name = "Luo",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "luy_KE",
                        new Language
                        {
                            Name = "Luyia (Kenya)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "luy",
                        new Language
                        {
                            Name = "Luyia",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "mk_MK",
                        new Language
                        {
                            Name = "Macedonian (Macedonia)",
                            Charset = "ISO-8859-5"
                        }
                    },
                    {
                        "mk",
                        new Language
                        {
                            Name = "Macedonian",
                            Charset = "ISO-8859-5"
                        }
                    },
                    {
                        "jmc_TZ",
                        new Language
                        {
                            Name = "Machame (Tanzania)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "jmc",
                        new Language
                        {
                            Name = "Machame",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "kde_TZ",
                        new Language
                        {
                            Name = "Makonde (Tanzania)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "kde",
                        new Language
                        {
                            Name = "Makonde",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "mg_MG",
                        new Language
                        {
                            Name = "Malagasy (Madagascar)",
                            Charset = "ISO-8859-15"
                        }
                    },
                    {
                        "mg",
                        new Language
                        {
                            Name = "Malagasy",
                            Charset = "ISO-8859-15"
                        }
                    },
                    {
                        "ms_BN",
                        new Language
                        {
                            Name = "Malay (Brunei)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "ms_MY",
                        new Language
                        {
                            Name = "Malay (Malaysia)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "ms",
                        new Language
                        {
                            Name = "Malay",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "ml_IN",
                        new Language
                        {
                            Name = "Malayalam (India)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "ml",
                        new Language
                        {
                            Name = "Malayalam",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "mt_MT",
                        new Language
                        {
                            Name = "Maltese (Malta)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "mt",
                        new Language
                        {
                            Name = "Maltese",
                            Charset = "ISO-8859-3"
                        }
                    },
                    {
                        "gv_GB",
                        new Language
                        {
                            Name = "Manx (United Kingdom)",
                            Charset = "ISO-8859-1"
                        }
                    },
                    {
                        "gv",
                        new Language
                        {
                            Name = "Manx",
                            Charset = "ISO-8859-1"
                        }
                    },
                    {
                        "mr_IN",
                        new Language
                        {
                            Name = "Marathi (India)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "mr",
                        new Language
                        {
                            Name = "Marathi",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "mas_KE",
                        new Language
                        {
                            Name = "Masai (Kenya)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "mas_TZ",
                        new Language
                        {
                            Name = "Masai (Tanzania)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "mas",
                        new Language
                        {
                            Name = "Masai",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "mer_KE",
                        new Language
                        {
                            Name = "Meru (Kenya)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "mer",
                        new Language
                        {
                            Name = "Meru",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "mfe_MU",
                        new Language
                        {
                            Name = "Morisyen (Mauritius)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "mfe",
                        new Language
                        {
                            Name = "Morisyen",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "naq_NA",
                        new Language
                        {
                            Name = "Nama (Namibia)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "naq",
                        new Language
                        {
                            Name = "Nama",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "ne_IN",
                        new Language
                        {
                            Name = "Nepali (India)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "ne_NP",
                        new Language
                        {
                            Name = "Nepali (Nepal)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "ne",
                        new Language
                        {
                            Name = "Nepali",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "nd_ZW",
                        new Language
                        {
                            Name = "North Ndebele (Zimbabwe)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "nd",
                        new Language
                        {
                            Name = "North Ndebele",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "nb_NO",
                        new Language
                        {
                            Name = "Norwegian Bokmål (Norway)",
                            Charset = "ISO-8859-1"
                        }
                    },
                    {
                        "nb",
                        new Language
                        {
                            Name = "Norwegian Bokmål",
                            Charset = "ISO-8859-1"
                        }
                    },
                    {
                        "nn_NO",
                        new Language
                        {
                            Name = "Norwegian Nynorsk (Norway)",
                            Charset = "ISO-8859-1"
                        }
                    },
                    {
                        "nn",
                        new Language
                        {
                            Name = "Norwegian Nynorsk",
                            Charset = "ISO-8859-1"
                        }
                    },
                    {
                        "nyn_UG",
                        new Language
                        {
                            Name = "Nyankole (Uganda)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "nyn",
                        new Language
                        {
                            Name = "Nyankole",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "or_IN",
                        new Language
                        {
                            Name = "Oriya (India)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "or",
                        new Language
                        {
                            Name = "Oriya",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "om_ET",
                        new Language
                        {
                            Name = "Oromo (Ethiopia)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "om_KE",
                        new Language
                        {
                            Name = "Oromo (Kenya)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "om",
                        new Language
                        {
                            Name = "Oromo",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "ps_AF",
                        new Language
                        {
                            Name = "Pashto (Afghanistan)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "ps",
                        new Language
                        {
                            Name = "Pashto",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "fa_AF",
                        new Language
                        {
                            Name = "Persian (Afghanistan)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "fa_IR",
                        new Language
                        {
                            Name = "Persian (Iran)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "fa",
                        new Language
                        {
                            Name = "Persian",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "pl_PL",
                        new Language
                        {
                            Name = "Polish (Poland)",
                            Charset = "ISO-8859-2"
                        }
                    },
                    {
                        "pl",
                        new Language
                        {
                            Name = "Polish",
                            Charset = "ISO-8859-2"
                        }
                    },
                    {
                        "pt_BR",
                        new Language
                        {
                            Name = "Portuguese (Brazil)",
                            Charset = "ISO-8859-1"
                        }
                    },
                    {
                        "pt_GW",
                        new Language
                        {
                            Name = "Portuguese (Guinea-Bissau)",
                            Charset = "ISO-8859-1"
                        }
                    },
                    {
                        "pt_MZ",
                        new Language
                        {
                            Name = "Portuguese (Mozambique)",
                            Charset = "ISO-8859-1"
                        }
                    },
                    {
                        "pt_PT",
                        new Language
                        {
                            Name = "Portuguese (Portugal)",
                            Charset = "ISO-8859-1"
                        }
                    },
                    {
                        "pt",
                        new Language
                        {
                            Name = "Portuguese",
                            Charset = "ISO-8859-1"
                        }
                    },
                    {
                        "pa_Arab",
                        new Language
                        {
                            Name = "Punjabi (Arabic)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "pa_Arab_PK",
                        new Language
                        {
                            Name = "Punjabi (Arabic, Pakistan)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "pa_Guru",
                        new Language
                        {
                            Name = "Punjabi (Gurmukhi)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "pa_Guru_IN",
                        new Language
                        {
                            Name = "Punjabi (Gurmukhi, India)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "pa",
                        new Language
                        {
                            Name = "Punjabi",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "ro_MD",
                        new Language
                        {
                            Name = "Romanian (Moldova)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "ro_RO",
                        new Language
                        {
                            Name = "Romanian (Romania)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "ro",
                        new Language
                        {
                            Name = "Romanian",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "rm_CH",
                        new Language
                        {
                            Name = "Romansh (Switzerland)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "rm",
                        new Language
                        {
                            Name = "Romansh",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "rof_TZ",
                        new Language
                        {
                            Name = "Rombo (Tanzania)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "rof",
                        new Language
                        {
                            Name = "Rombo",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "ru_MD",
                        new Language
                        {
                            Name = "Russian (Moldova)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "ru_RU",
                        new Language
                        {
                            Name = "Russian (Russia)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "ru_UA",
                        new Language
                        {
                            Name = "Russian (Ukraine)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "ru",
                        new Language
                        {
                            Name = "Russian",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "rwk_TZ",
                        new Language
                        {
                            Name = "Rwa (Tanzania)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "rwk",
                        new Language
                        {
                            Name = "Rwa",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "saq_KE",
                        new Language
                        {
                            Name = "Samburu (Kenya)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "saq",
                        new Language
                        {
                            Name = "Samburu",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "sg_CF",
                        new Language
                        {
                            Name = "Sango (Central African Republic)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "sg",
                        new Language
                        {
                            Name = "Sango",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "seh_MZ",
                        new Language
                        {
                            Name = "Sena (Mozambique)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "seh",
                        new Language
                        {
                            Name = "Sena",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "sr_Cyrl",
                        new Language
                        {
                            Name = "Serbian (Cyrillic)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "sr_Cyrl_BA",
                        new Language
                        {
                            Name = "Serbian (Cyrillic, Bosnia and Herzegovina)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "sr_Cyrl_ME",
                        new Language
                        {
                            Name = "Serbian (Cyrillic, Montenegro)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "sr_Cyrl_RS",
                        new Language
                        {
                            Name = "Serbian (Cyrillic, Serbia)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "sr_Latn",
                        new Language
                        {
                            Name = "Serbian (Latin)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "sr_Latn_BA",
                        new Language
                        {
                            Name = "Serbian (Latin, Bosnia and Herzegovina)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "sr_Latn_ME",
                        new Language
                        {
                            Name = "Serbian (Latin, Montenegro)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "sr_Latn_RS",
                        new Language
                        {
                            Name = "Serbian (Latin, Serbia)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "sr",
                        new Language
                        {
                            Name = "Serbian",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "sn_ZW",
                        new Language
                        {
                            Name = "Shona (Zimbabwe)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "sn",
                        new Language
                        {
                            Name = "Shona",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "ii_CN",
                        new Language
                        {
                            Name = "Sichuan Yi (China)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "ii",
                        new Language
                        {
                            Name = "Sichuan Yi",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "si_LK",
                        new Language
                        {
                            Name = "Sinhala (Sri Lanka)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "si",
                        new Language
                        {
                            Name = "Sinhala",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "sk_SK",
                        new Language
                        {
                            Name = "Slovak (Slovakia)",
                            Charset = "ISO-8859-2"
                        }
                    },
                    {
                        "sk",
                        new Language
                        {
                            Name = "Slovak",
                            Charset = "ISO-8859-2"
                        }
                    },
                    {
                        "sl_SI",
                        new Language
                        {
                            Name = "Slovenian (Slovenia)",
                            Charset = "ISO-8859-2"
                        }
                    },
                    {
                        "sl",
                        new Language
                        {
                            Name = "Slovenian",
                            Charset = "ISO-8859-2"
                        }
                    },
                    {
                        "xog_UG",
                        new Language
                        {
                            Name = "Soga (Uganda)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "xog",
                        new Language
                        {
                            Name = "Soga",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "so_DJ",
                        new Language
                        {
                            Name = "Somali (Djibouti)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "so_ET",
                        new Language
                        {
                            Name = "Somali (Ethiopia)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "so_KE",
                        new Language
                        {
                            Name = "Somali (Kenya)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "so_SO",
                        new Language
                        {
                            Name = "Somali (Somalia)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "so",
                        new Language
                        {
                            Name = "Somali",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "es_AR",
                        new Language
                        {
                            Name = "Spanish (Argentina)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "es_BO",
                        new Language
                        {
                            Name = "Spanish (Bolivia)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "es_CL",
                        new Language
                        {
                            Name = "Spanish (Chile)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "es_CO",
                        new Language
                        {
                            Name = "Spanish (Colombia)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "es_CR",
                        new Language
                        {
                            Name = "Spanish (Costa Rica)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "es_DO",
                        new Language
                        {
                            Name = "Spanish (Dominican Republic)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "es_EC",
                        new Language
                        {
                            Name = "Spanish (Ecuador)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "es_SV",
                        new Language
                        {
                            Name = "Spanish (El Salvador)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "es_GQ",
                        new Language
                        {
                            Name = "Spanish (Equatorial Guinea)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "es_GT",
                        new Language
                        {
                            Name = "Spanish (Guatemala)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "es_HN",
                        new Language
                        {
                            Name = "Spanish (Honduras)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "es_419",
                        new Language
                        {
                            Name = "Spanish (Latin America)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "es_MX",
                        new Language
                        {
                            Name = "Spanish (Mexico)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "es_NI",
                        new Language
                        {
                            Name = "Spanish (Nicaragua)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "es_PA",
                        new Language
                        {
                            Name = "Spanish (Panama)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "es_PY",
                        new Language
                        {
                            Name = "Spanish (Paraguay)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "es_PE",
                        new Language
                        {
                            Name = "Spanish (Peru)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "es_PR",
                        new Language
                        {
                            Name = "Spanish (Puerto Rico)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "es_ES",
                        new Language
                        {
                            Name = "Spanish (Spain)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "es_US",
                        new Language
                        {
                            Name = "Spanish (United States)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "es_UY",
                        new Language
                        {
                            Name = "Spanish (Uruguay)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "es_VE",
                        new Language
                        {
                            Name = "Spanish (Venezuela)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "es",
                        new Language
                        {
                            Name = "Spanish",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "sw_KE",
                        new Language
                        {
                            Name = "Swahili (Kenya)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "sw_TZ",
                        new Language
                        {
                            Name = "Swahili (Tanzania)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "sw",
                        new Language
                        {
                            Name = "Swahili",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "sv_FI",
                        new Language
                        {
                            Name = "Swedish (Finland)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "sv_SE",
                        new Language
                        {
                            Name = "Swedish (Sweden)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "sv",
                        new Language
                        {
                            Name = "Swedish",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "gsw_CH",
                        new Language
                        {
                            Name = "Swiss German (Switzerland)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "gsw",
                        new Language
                        {
                            Name = "Swiss German",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "shi_Latn",
                        new Language
                        {
                            Name = "Tachelhit (Latin)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "shi_Latn_MA",
                        new Language
                        {
                            Name = "Tachelhit (Latin, Morocco)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "shi_Tfng",
                        new Language
                        {
                            Name = "Tachelhit (Tifinagh)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "shi_Tfng_MA",
                        new Language
                        {
                            Name = "Tachelhit (Tifinagh, Morocco)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "shi",
                        new Language
                        {
                            Name = "Tachelhit",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "dav_KE",
                        new Language
                        {
                            Name = "Taita (Kenya)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "dav",
                        new Language
                        {
                            Name = "Taita",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "ta_IN",
                        new Language
                        {
                            Name = "Tamil (India)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "ta_LK",
                        new Language
                        {
                            Name = "Tamil (Sri Lanka)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "ta",
                        new Language
                        {
                            Name = "Tamil",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "te_IN",
                        new Language
                        {
                            Name = "Telugu (India)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "te",
                        new Language
                        {
                            Name = "Telugu",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "teo_KE",
                        new Language
                        {
                            Name = "Teso (Kenya)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "teo_UG",
                        new Language
                        {
                            Name = "Teso (Uganda)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "teo",
                        new Language
                        {
                            Name = "Teso",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "th_TH",
                        new Language
                        {
                            Name = "Thai (Thailand)",
                            Charset = "TIS-620"
                        }
                    },
                    {
                        "th",
                        new Language
                        {
                            Name = "Thai",
                            Charset = "TIS-620"
                        }
                    },
                    {
                        "bo_CN",
                        new Language
                        {
                            Name = "Tibetan (China)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "bo_IN",
                        new Language
                        {
                            Name = "Tibetan (India)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "bo",
                        new Language
                        {
                            Name = "Tibetan",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "ti_ER",
                        new Language
                        {
                            Name = "Tigrinya (Eritrea)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "ti_ET",
                        new Language
                        {
                            Name = "Tigrinya (Ethiopia)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "ti",
                        new Language
                        {
                            Name = "Tigrinya",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "to_TO",
                        new Language
                        {
                            Name = "Tonga (Tonga)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "to",
                        new Language
                        {
                            Name = "Tonga",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "tr_TR",
                        new Language
                        {
                            Name = "Turkish (Turkey)",
                            Charset = "ISO-8859-9"
                        }
                    },
                    {
                        "tr",
                        new Language
                        {
                            Name = "Turkish",
                            Charset = "ISO-8859-9"
                        }
                    },
                    {
                        "uk_UA",
                        new Language
                        {
                            Name = "Ukrainian (Ukraine)",
                            Charset = "KOI8-U"
                        }
                    },
                    {
                        "uk",
                        new Language
                        {
                            Name = "Ukrainian",
                            Charset = "KOI8-U"
                        }
                    },
                    {
                        "ur_IN",
                        new Language
                        {
                            Name = "Urdu (India)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "ur_PK",
                        new Language
                        {
                            Name = "Urdu (Pakistan)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "ur",
                        new Language
                        {
                            Name = "Urdu",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "uz_Arab",
                        new Language
                        {
                            Name = "Uzbek (Arabic)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "uz_Arab_AF",
                        new Language
                        {
                            Name = "Uzbek (Arabic, Afghanistan)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "uz_Cyrl",
                        new Language
                        {
                            Name = "Uzbek (Cyrillic)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "uz_Cyrl_UZ",
                        new Language
                        {
                            Name = "Uzbek (Cyrillic, Uzbekistan)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "uz_Latn",
                        new Language
                        {
                            Name = "Uzbek (Latin)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "uz_Latn_UZ",
                        new Language
                        {
                            Name = "Uzbek (Latin, Uzbekistan)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "uz",
                        new Language
                        {
                            Name = "Uzbek",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "vi_VN",
                        new Language
                        {
                            Name = "Vietnamese (Vietnam)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "vi",
                        new Language
                        {
                            Name = "Vietnamese",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "vun_TZ",
                        new Language
                        {
                            Name = "Vunjo (Tanzania)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "vun",
                        new Language
                        {
                            Name = "Vunjo",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "cy_GB",
                        new Language
                        {
                            Name = "Welsh (United Kingdom)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "cy",
                        new Language
                        {
                            Name = "Welsh",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "yo_NG",
                        new Language
                        {
                            Name = "Yoruba (Nigeria)",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "yo",
                        new Language
                        {
                            Name = "Yoruba",
                            Charset = "UTF-8"
                        }
                    },
                    {
                        "zu_ZA",
                        new Language
                        {
                            Name = "Zulu (South Africa)",
                            Charset = "ISO-8859-1"
                        }
                    },
                    {
                        "zu",
                        new Language
                        {
                            Name = "Zulu",
                            Charset = "ISO-8859-1"
                        }
                    }
                };
    }
}
