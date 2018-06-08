using Patterns.Ex01.ExternalLibs.Instagram;
using Patterns.Ex01.ExternalLibs.Twitter;
using System;

namespace Patterns.Ex01
{
    public class SubscriberViewer
    {
        /// <summary>
        /// ���������� ������ ����������� ������������ �� ���.����.
        /// TODO: ���������� �������� ���� ����� �� �������� ������
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="networkType"></param>
        /// <returns></returns>
        /// 
        
        
        public SocialNetworkUser[] GetSubscribers(String userName, SocialNetwork networkType) 
        {
            
            switch(networkType){
                case SocialNetwork.Twitter:
                    
                    TwitterClient tClient = new TwitterClient();
                    long idTClient = tClient.GetUserNameById(userName);
                    return tClient;
                    
                case SocialNetwork.Instagram:
                    InstagramClient iClient = new InstagramClient();
                    break;
            }
            return null;
        }

        public interface ILogic
        {
            SocialNetworkUser[] GetSubscribers(userName);
        }




    }
}