﻿using Microsoft.AspNetCore.StaticFiles;

namespace TestTestCMS.Services.MessageHandlers;

public class FolderMessageHandler(IFolderService folderService, IFileService fileService) : IMessageHandler<SiteTemplate>
{
    public async Task Handle(Message<SiteTemplate> notification, CancellationToken cancellationToken)
    {
        switch (notification.Action)
        {
            case ActionNames.SiteCreated:
                await CreateFolders(notification.Payload, cancellationToken);
                break;

            default:
                break;
        }
    }

    private async Task CreateFolders(SiteTemplate siteTemplate, CancellationToken cancellationToken)
    {
        var rootFolder = await folderService.CreateRoot(siteTemplate.Id, cancellationToken);

        // read from assets folder and create Folders object model for the site
        var assetsPath = System.IO.Path.Combine(ServiceConstants.SetupTemplatesFolder, siteTemplate.Template, ServiceConstants.SetupFilesFolder);

        await CreateChildFolders(siteTemplate.Id, rootFolder, assetsPath, cancellationToken);
    }

    private async Task CreateChildFolders(Guid siteId, Folder parentFolder, string path, CancellationToken cancellationToken)
    {
        if (System.IO.Directory.Exists(path))
        {
            foreach (var folderName in System.IO.Directory.GetDirectories(path))
            {
                var folder = new Folder
                {
                    Id = Guid.NewGuid(),
                    Name = new System.IO.DirectoryInfo(folderName).Name,
                    SiteId = siteId,
                    ParentId = parentFolder.Id
                };
                await folderService.Create(folder, cancellationToken);
                await CreateChildFolders(siteId, folder, folderName, cancellationToken);
            }

            foreach (var fileName in System.IO.Directory.GetFiles(path))
            {
                var file = new File
                {
                    Id = Guid.NewGuid(),
                    Name = new System.IO.FileInfo(fileName).Name,
                    SiteId = siteId,
                    FolderId = parentFolder.Id,
                    Size = new System.IO.FileInfo(fileName).Length,
                    ContentType = GetContentType(fileName),
                    Extension = new System.IO.FileInfo(fileName).Extension
                };
                using var contentStream = new System.IO.FileStream(fileName, System.IO.FileMode.Open);
                await fileService.Create(file, contentStream, cancellationToken);
            }
        }
    }

    private static string GetContentType(string fileName)
    {
        var provider = new FileExtensionContentTypeProvider();
        if (!provider.TryGetContentType(fileName, out var contentType))
        {
            // If the file extension is not recognized, default to a generic content type
            contentType = "application/octet-stream";
        }
        return contentType;
    }

}