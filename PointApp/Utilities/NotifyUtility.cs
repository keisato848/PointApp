﻿using Xamarin.Forms;

namespace PointApp.Utilities
{
    internal class NotifyUtility
    {
        public enum ErrorCode
        {
            UserDuplicated = 0,
            OverUserCount = 1,
            LackStartUser = 2,
            LackFinishUser = 3,
            CalcError = 4,
            IdEmpty = 5,
            PwdEmpty = 6,
            CompetitionNameEmpty = 7,
            InvalidNetwork = 8,
        }

        public static async void DisplayErrorMessage(Page page, ErrorCode errorCode)
        {
            switch (errorCode)
            {
                case ErrorCode.UserDuplicated:
                    await page.DisplayAlert("通知", "選手が重複しています。", "OK");
                    break;

                case ErrorCode.OverUserCount:
                    await page.DisplayAlert("通知", "これ以上選択できません。", "OK");
                    break;

                case ErrorCode.LackStartUser:
                    await page.DisplayAlert("通知", "項番３は５人選択してください。", "OK");
                    break;

                case ErrorCode.LackFinishUser:
                    await page.DisplayAlert("通知", "項番４は５人以上選択してください。", "OK");
                    break;

                case ErrorCode.CalcError:
                    await page.DisplayAlert("通知", "管理者に報告してください。", "OK");
                    break;

                case ErrorCode.IdEmpty:
                    await page.DisplayAlert("通知", "IDを入力してください。", "OK");
                    break;

                case ErrorCode.PwdEmpty:
                    await page.DisplayAlert("通知", "パスワードを入力してください。", "OK");
                    break;

                case ErrorCode.CompetitionNameEmpty:
                    await page.DisplayAlert("通知", "大会名を入力してください。", "OK");
                    break;

                case ErrorCode.InvalidNetwork:
                    await page.DisplayAlert("通知", "ネットワークに接続されていません。", "OK");
                    break;

                default:
                    break;
            }
        }
    }
}
