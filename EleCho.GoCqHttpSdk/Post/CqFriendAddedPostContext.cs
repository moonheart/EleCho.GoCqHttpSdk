﻿
using EleCho.GoCqHttpSdk.Post.Model;

namespace EleCho.GoCqHttpSdk.Post
{
    /// <summary>
    /// 好友已添加
    /// </summary>
    public class CqFriendAddedPostContext : CqNoticePostContext
    {
        public override CqNoticeType NoticeType => CqNoticeType.FriendAdd;

        public long UserId { get; set; }

        internal CqFriendAddedPostContext() { }

        internal override object? QuickOperationModel => null;
        internal override void ReadModel(CqPostModel model)
        {
            base.ReadModel(model);

            if (model is not CqNoticeFriendAddPostModel noticeModel)
                return;

            UserId = noticeModel.user_id;
        }
    }
}