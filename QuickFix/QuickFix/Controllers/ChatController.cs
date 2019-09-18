using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using QuickFix.Models;

namespace QuickFix.Controllers
{
    [Authorize]
    public class ChatController : Controller
    {
        public readonly AppDbContext _context;
        public readonly UserManager<AppUser> _userManager;

        public ChatController(AppDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Chat
        public async Task<IActionResult> Index()
        {
            var currentUser = await _userManager.GetUserAsync(User);
            if(User.Identity.IsAuthenticated)
            {
                ViewBag.CurrentUserName = currentUser.UserName;
            }          
            var messages = await _context.Messages.ToListAsync();
            return View(messages);
        }


        public async Task<IActionResult> Create(Message message)
        {
            if (ModelState.IsValid)
            {
                message.UserName = User.Identity.Name;
                var sender = await _userManager.GetUserAsync(User);
                message.UserID = sender.Id;
                await _context.Messages.AddAsync(message);
                await _context.SaveChangesAsync();
                return Ok();
                //_context.Add(message);
                //await _context.SaveChangesAsync();
                // return RedirectToAction(nameof(Index));
            }
            return Error();
            //ViewData["UserID"] = new SelectList(_context.Set<AppUser>(), "Id", "Id", message.UserID);
            //return View(message);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}