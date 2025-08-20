using Unity.Netcode;
using Unity.Netcode.Transports.UTP;
using UnityEngine;

public class HostIpUI : MonoBehaviour
{
    [SerializeField] private UnityTransport m_Transport;
    
    void SetHostIP(string ipAddress){
        m_Transport.ConnectionData.Address = ipAddress;
    }
}
