﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Music_Application.DAL
{
    public class DAL_Playlists
    {
        private static DAL_Playlists instance;
        public static DAL_Playlists Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAL_Playlists();
                }
                return instance;
            }
        }
        private DAL_Playlists()
        {

        }
        public void AddPlaylist(Playlist playlist)
        {
            MusicAppEntities db = new MusicAppEntities();
            db.Playlists.Add(playlist);
            db.SaveChanges();
        }
        public void UpdatePlaylistName(int PlaylistID, string newName)
        {
            MusicAppEntities db = new MusicAppEntities();
            var playlist = db.Playlists.Find(PlaylistID);
            playlist.PlaylistName = newName;
            db.SaveChanges();
        }
        public void UpdatePlaylistMusics(int PlaylistID, int newMusicID)
        {
            MusicAppEntities db = new MusicAppEntities();
            var playlist = db.Playlists.Find(PlaylistID);
            var newMusic = db.Musics.Find(newMusicID);
            playlist.Musics.Add(newMusic);
            db.SaveChanges();
        }
        public void RemovePlaylist(int PlaylistID)
        {
            MusicAppEntities db = new MusicAppEntities();
            var playlist = db.Playlists.Where(p => p.PlaylistID == PlaylistID).FirstOrDefault();
            playlist.Musics.Clear();
            db.Playlists.Remove(playlist);
            db.SaveChanges();
        }
        public List<Playlist> GetPlaylists(int UserID)
        {
            MusicAppEntities db = new MusicAppEntities();
            var list = db.Playlists.Where(p => p.UserID == UserID);
            return list.ToList();
        }
        public Playlist GetPlaylistByID(int id)
        {
            MusicAppEntities db = new MusicAppEntities();
            var playlist = db.Playlists.Where(p => p.PlaylistID == id).FirstOrDefault();
            return playlist;
        }
        public void RemoveMusicFromPlaylist(int PlaylistID, int MusicID)
        {
            MusicAppEntities db = new MusicAppEntities();
            var playlist = db.Playlists.Where(p => p.PlaylistID == PlaylistID).FirstOrDefault();
            var music = db.Musics.Where(p => p.MusicID == MusicID).FirstOrDefault();
            playlist.Musics.Remove(music);
            db.SaveChanges();
        }
    }
}
