﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Threading.Tasks;
using NAPS2.ImportExport.Email;
using NAPS2.ImportExport.Email.Mapi;
using NAPS2.Scan;
using NAPS2.Scan.Images;

namespace NAPS2.Worker
{
    /// <summary>
    /// The WCF service interface for NAPS2.Worker.exe.
    /// </summary>
    [ServiceContract(CallbackContract = typeof(IWorkerCallback))]
    public interface IWorkerService
    {
        [OperationContract]
        void Init(string recoveryFolderPath);

        [OperationContract]
        List<ScanDevice> TwainGetDeviceList(TwainImpl twainImpl);

        [FaultContract(typeof(ScanDriverExceptionDetail))]
        [OperationContract]
        Task TwainScan(ScanDevice scanDevice, ScanProfile scanProfile, ScanParams scanParams, IntPtr hwnd);

        [OperationContract]
        void CancelTwainScan();

        [OperationContract]
        MapiSendMailReturnCode SendMapiEmail(EmailMessage message);

        [OperationContract]
        byte[] RenderThumbnail(ScannedImage.Snapshot snapshot, int size);
    }
}
