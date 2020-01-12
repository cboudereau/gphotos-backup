/// Store metadata, in data file jpg or mp4 using exif format or with an associated <fileName>.json file

let imagePath = """C:\Users\Clément\Pictures\DSC00274.JPG"""
let metadata = """
{
  "id": string,
  "description": string,
  "productUrl": string,
  "baseUrl": string,
  "mimeType": string,
  "mediaMetadata": {
    object (MediaMetadata)
  },
  "contributorInfo": {
    object (ContributorInfo)
  },
  "filename": string
}
"""
open System.IO

let fileInfo = FileInfo(imagePath)

let fs = DirectoryInfo("""C:\Users\Clément\Pictures\""").GetFileSystemInfos("*.jpg").[0]