#load ".paket/load/netcoreapp3.0/main.group.fsx"

open FSharp.Data

///Read remote files

let scope = """https://www.googleapis.com/auth/photoslibrary.readonly"""



let response = """{
"mediaItems": [
  {
    "id": "dfrgermfg,erm,relkgnlinUBjkbvgkrf",
    "productUrl": "https://photos.google.com/lr/photo/dfrgermfg,erm,relkgnlinUBjkbvgkrf",
    "baseUrl": "https://lh3.googleusercontent.com/lr/efzefrevefvd"
    "mimeType": "image/jpeg",
    "mediaMetadata": {
      "creationTime": "2019-03-09T12:42:00Z",
      "width": "3264",
      "height": "1836",
      "photo": {
        "cameraMake": "samsung",
        "cameraModel": "SM-G965F",
        "focalLength": 2.92,
        "apertureFNumber": 1.7,
        "isoEquivalent": 125
      }
    },
    "filename": "20190309_134201.jpg"
  },
  {
    "id": "dfrgermfg,erm,relkgnlinUBjkbvgkrf",
    "productUrl": "https://photos.google.com/lr/photo/dfrgermfg,erm,relkgnlinUBjkbvgkrf",
    "baseUrl": "https://lh3.googleusercontent.com/lr/efzefrevefvd"
    "mimeType": "image/jpeg",
    "mediaMetadata": {
      "creationTime": "2019-03-09T12:42:00Z",
      "width": "3264",
      "height": "1836",
      "photo": {
        "cameraMake": "samsung",
        "cameraModel": "SM-G965F",
        "focalLength": 2.92,
        "apertureFNumber": 1.7,
        "isoEquivalent": 125
      }
    },
    "filename": "20190309_134201.jpg"
  }
],
"nextPageToken": "dfgdfgregegetgvetbrgbgb"
}"""

///Compare local and remote then get the delta to sync

///Download files